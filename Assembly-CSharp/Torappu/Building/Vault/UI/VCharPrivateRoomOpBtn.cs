using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;

namespace Torappu.Building.Vault.UI
{
	// Token: 0x02001A94 RID: 6804
	[Token(Token = "0x2001A94")]
	public class VCharPrivateRoomOpBtn : VOUIPanel
	{
		// Token: 0x0600AB77 RID: 43895 RVA: 0x00042540 File Offset: 0x00040740
		[Token(Token = "0x600AB77")]
		[Address(RVA = "0x3287890", Offset = "0x3286490", VA = "0x183287890", Slot = "4")]
		public override bool MatchObject(BuildingEvent evt, VRoom.Object roomObject)
		{
			return default(bool);
		}

		// Token: 0x0600AB78 RID: 43896 RVA: 0x00042558 File Offset: 0x00040758
		[Token(Token = "0x600AB78")]
		[Address(RVA = "0x3288170", Offset = "0x3286D70", VA = "0x183288170")]
		private bool _MatchObjectWhenVisit(BuildingEvent evt, VRoom.Object roomObject)
		{
			return default(bool);
		}

		// Token: 0x0600AB79 RID: 43897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB79")]
		[Address(RVA = "0x3287CD0", Offset = "0x32868D0", VA = "0x183287CD0", Slot = "7")]
		protected override void OnRoomObjectStatusChanged()
		{
		}

		// Token: 0x0600AB7A RID: 43898 RVA: 0x00042570 File Offset: 0x00040770
		[Token(Token = "0x600AB7A")]
		[Address(RVA = "0x3287D30", Offset = "0x3286930", VA = "0x183287D30", Slot = "5")]
		protected override Vector3 PanelWorldCenter()
		{
			return default(Vector3);
		}

		// Token: 0x0600AB7B RID: 43899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB7B")]
		[Address(RVA = "0x3287E80", Offset = "0x3286A80", VA = "0x183287E80", Slot = "9")]
		protected override void UpdateRender()
		{
		}

		// Token: 0x0600AB7C RID: 43900 RVA: 0x00042588 File Offset: 0x00040788
		[Token(Token = "0x600AB7C")]
		[Address(RVA = "0x3288110", Offset = "0x3286D10", VA = "0x183288110")]
		private bool _IsLodVisible()
		{
			return default(bool);
		}

		// Token: 0x0600AB7D RID: 43901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB7D")]
		[Address(RVA = "0x3287A90", Offset = "0x3286690", VA = "0x183287A90")]
		public void OnClick()
		{
		}

		// Token: 0x0600AB7E RID: 43902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB7E")]
		[Address(RVA = "0x32882C0", Offset = "0x3286EC0", VA = "0x1832882C0")]
		public VCharPrivateRoomOpBtn()
		{
		}

		// Token: 0x0400A3B3 RID: 41907
		[Token(Token = "0x400A3B3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _btnCanvasGroup;

		// Token: 0x0400A3B4 RID: 41908
		[Token(Token = "0x400A3B4")]
		[FieldOffset(Offset = "0x30")]
		private FadeSwitchTween m_btnSwitch;
	}
}
