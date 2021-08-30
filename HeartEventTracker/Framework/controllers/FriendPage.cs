using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewValley;
using StardewValley.Menus;
using SDVSocialPage = StardewValley.Menus.SocialPage;
using System.Diagnostics;

namespace HeartEventTracker.Framework
{
    internal class FriendPage
    {

        /*********
        ** Properties
        *********/
        /// <summary>The underlying social menu.</summary>
        private SDVSocialPage NativeSocialPage;

        /// <summary>Simplifies access to private game code.</summary>
        private IReflectionHelper ReflectionHelper;

        private List<ClickableTextureComponent> FriendRows;
        private List<object> Names; // Other player names are ints, NPC names are strings.

        private Vector2 RowBoundsOffset;
        private float RowHeight;
        private Rectangle PageBounds;
        private int LastRowIndex;

        /// <summary>Fires when the current slot index changes due to scrolling the list.</summary>
        public delegate void SlotIndexChangedDelegate();
        public event SlotIndexChangedDelegate OnSlotIndexChanged;


        public string GetCurrentlyHoveredNpc(Vector2 mousePos)
        {
            int slotPos = this.GetSlotPosition();

            // Exit if the mouse isn't in the page bounds
            Point mousePoint = Utils.Vector2ToPoint(mousePos);
            if (!this.PageBounds.Contains(mousePoint))
            {
                return string.Empty;
            }

            // Find the slot containing the cursor among the currentl    y visible slots
            string hoveredFriendName = string.Empty;
            for (int i = slotPos; i < slotPos + SDVSocialPage.slotsOnPage; ++i)
            {
                var friend = this.FriendRows[i];
                var bounds = this.MakeSlotBounds(friend);

                if (bounds.Contains(mousePoint))
                {
                    Debug.Assert(i < this.Names.Count, "Name index is out of range");
                    hoveredFriendName = this.Names[i] as string;
                    break;
                }
            }

            return hoveredFriendName ?? string.Empty;
        }

        private int GetSlotPosition()
        {
            return this.ReflectionHelper.GetField<int>(this.NativeSocialPage, "slotPosition").GetValue();
        }

        private Rectangle MakeSlotBounds(ClickableTextureComponent slot)
        {
            return Utils.MakeRect(
                (slot.bounds.X - this.RowBoundsOffset.X),
                (slot.bounds.Y - this.RowBoundsOffset.Y),
                (slot.bounds.Width - Game1.tileSize),
                this.RowHeight - this.RowBoundsOffset.Y // account for border between each slot
            );
        }
    }
}
