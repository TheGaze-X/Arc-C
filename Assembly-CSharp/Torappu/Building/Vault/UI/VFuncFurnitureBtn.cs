using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;

namespace Torappu.Building.Vault.UI
{
	// Token: 0x02001A83 RID: 6787
	[Token(Token = "0x2001A83")]
	public class VFuncFurnitureBtn : VOUIPanel
	{
		// Token: 0x0600AB25 RID: 43813 RVA: 0x000422B8 File Offset: 0x000404B8
		[Token(Token = "0x600AB25")]
		[Address(RVA = "0x325E890", Offset = "0x325D490", VA = "0x18325E890", Slot = "4")]
		public override bool MatchObject(BuildingEvent evt, VRoom.Object roomObject)
		{
			return default(bool);
		}

		// Token: 0x0600AB26 RID: 43814 RVA: 0x000422D0 File Offset: 0x000404D0
		[Token(Token = "0x600AB26")]
		[Address(RVA = "0x325ED00", Offset = "0x325D900", VA = "0x18325ED00", Slot = "5")]
		protected override Vector3 PanelWorldCenter()
		{
			return default(Vector3);
		}

		// Token: 0x0600AB27 RID: 43815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB27")]
		[Address(RVA = "0x325EB30", Offset = "0x325D730", VA = "0x18325EB30", Slot = "6")]
		protected override void OnRoomObjectBinded(VRoom.Object roomObj)
		{
		}

		// Token: 0x0600AB28 RID: 43816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB28")]
		[Address(RVA = "0x325ECC0", Offset = "0x325D8C0", VA = "0x18325ECC0", Slot = "7")]
		protected override void OnRoomObjectStatusChanged()
		{
		}

		// Token: 0x0600AB29 RID: 43817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB29")]
		[Address(RVA = "0x325EF30", Offset = "0x325DB30", VA = "0x18325EF30", Slot = "9")]
		protected override void UpdateRender()
		{
		}

		// Token: 0x0600AB2A RID: 43818 RVA: 0x000422E8 File Offset: 0x000404E8
		[Token(Token = "0x600AB2A")]
		[Address(RVA = "0x325F000", Offset = "0x325DC00", VA = "0x18325F000", Slot = "10")]
		protected virtual bool _CheckShowBtn()
		{
			return default(bool);
		}

		// Token: 0x0600AB2B RID: 43819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB2B")]
		[Address(RVA = "0x325F0F0", Offset = "0x325DCF0", VA = "0x18325F0F0", Slot = "11")]
		protected virtual void _UpdateStatus()
		{
		}

		// Token: 0x0600AB2C RID: 43820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB2C")]
		[Address(RVA = "0x325EA00", Offset = "0x325D600", VA = "0x18325EA00")]
		public void OnClick()
		{
		}

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x0600AB2D RID: 43821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001436")]
		private ILODHolder lodHolder
		{
			[Token(Token = "0x600AB2D")]
			[Address(RVA = "0x325F190", Offset = "0x325DD90", VA = "0x18325F190")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x0600AB2E RID: 43822 RVA: 0x00042300 File Offset: 0x00040500
		[Token(Token = "0x17001437")]
		protected bool lodVisible
		{
			[Token(Token = "0x600AB2E")]
			[Address(RVA = "0x325F1F0", Offset = "0x325DDF0", VA = "0x18325F1F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600AB2F RID: 43823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB2F")]
		[Address(RVA = "0x3253DC0", Offset = "0x32529C0", VA = "0x183253DC0")]
		public VFuncFurnitureBtn()
		{
		}

		// Token: 0x0400A376 RID: 41846
		[Token(Token = "0x400A376")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuildingData.FurnitureSubType _subType;

		// Token: 0x0400A377 RID: 41847
		[Token(Token = "0x400A377")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _uiPanel;

		// Token: 0x0400A378 RID: 41848
		[Token(Token = "0x400A378")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _trackPoint;

		// Token: 0x0400A379 RID: 41849
		[Token(Token = "0x400A379")]
		[FieldOffset(Offset = "0x40")]
		protected BuildingData.FurnitureSubType m_subType;

		// Token: 0x0400A37A RID: 41850
		[Token(Token = "0x400A37A")]
		[FieldOffset(Offset = "0x44")]
		protected bool m_showTrackPoint;

		// Token: 0x0400A37B RID: 41851
		[Token(Token = "0x400A37B")]
		[FieldOffset(Offset = "0x45")]
		protected bool m_funcInUse;

		// Token: 0x0400A37C RID: 41852
		[Token(Token = "0x400A37C")]
		[FieldOffset(Offset = "0x48")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x0400A37D RID: 41853
		[Token(Token = "0x400A37D")]
		[FieldOffset(Offset = "0x50")]
		private ILODHolder m_lodHolder;
	}
}
