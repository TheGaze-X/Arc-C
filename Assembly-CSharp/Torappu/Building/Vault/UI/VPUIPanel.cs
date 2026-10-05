using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.Vault.UI
{
	// Token: 0x02001A7F RID: 6783
	[Token(Token = "0x2001A7F")]
	[RequireComponent(typeof(RectTransform))]
	public abstract class VPUIPanel : MonoBehaviour
	{
		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x0600AAF5 RID: 43765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700142E")]
		protected RoomSlotModel slotModel
		{
			[Token(Token = "0x600AAF5")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AAF6 RID: 43766
		[Token(Token = "0x600AAF6")]
		public abstract bool IsPrefabMatch(RoomSlotModel slotModel);

		// Token: 0x0600AAF7 RID: 43767
		[Token(Token = "0x600AAF7")]
		public abstract bool IsValid(RoomSlotModel slotModel);

		// Token: 0x0600AAF8 RID: 43768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAF8")]
		[Address(RVA = "0x3265800", Offset = "0x3264400", VA = "0x183265800")]
		public void Render(RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AAF9 RID: 43769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAF9")]
		[Address(RVA = "0x3264D80", Offset = "0x3263980", VA = "0x183264D80")]
		public void TriggerLayoutChange()
		{
		}

		// Token: 0x0600AAFA RID: 43770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAFA")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		protected virtual void OnRender()
		{
		}

		// Token: 0x0600AAFB RID: 43771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAFB")]
		[Address(RVA = "0x32657F0", Offset = "0x32643F0", VA = "0x1832657F0", Slot = "7")]
		protected virtual void OnLayoutChanged()
		{
		}

		// Token: 0x0600AAFC RID: 43772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAFC")]
		[Address(RVA = "0x3265840", Offset = "0x3264440", VA = "0x183265840")]
		private void _ResetPanelPos()
		{
		}

		// Token: 0x0600AAFD RID: 43773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAFD")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		protected VPUIPanel()
		{
		}

		// Token: 0x0400A34D RID: 41805
		[Token(Token = "0x400A34D")]
		private const float PANEL_MIN_HEIGHT = 0.1f;

		// Token: 0x0400A34E RID: 41806
		[Token(Token = "0x400A34E")]
		[FieldOffset(Offset = "0x18")]
		private RoomSlotModel m_slotModel;
	}
}
