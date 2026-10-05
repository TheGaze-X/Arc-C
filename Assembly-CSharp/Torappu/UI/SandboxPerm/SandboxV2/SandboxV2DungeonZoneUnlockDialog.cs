using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041BD RID: 16829
	[Token(Token = "0x20041BD")]
	public class SandboxV2DungeonZoneUnlockDialog : UICompDialog<SandboxV2DungeonZoneUnlockDialog.Option>
	{
		// Token: 0x06019F2C RID: 106284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F2C")]
		[Address(RVA = "0x12E3A90", Offset = "0x12E2690", VA = "0x1812E3A90", Slot = "18")]
		protected override void OnRender(SandboxV2DungeonZoneUnlockDialog.Option input)
		{
		}

		// Token: 0x06019F2D RID: 106285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F2D")]
		[Address(RVA = "0x12E3D70", Offset = "0x12E2970", VA = "0x1812E3D70")]
		public void PlayNameShowAudio()
		{
		}

		// Token: 0x06019F2E RID: 106286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019F2E")]
		[Address(RVA = "0x12E3E80", Offset = "0x12E2A80", VA = "0x1812E3E80")]
		public SandboxV2DungeonZoneUnlockDialog()
		{
		}

		// Token: 0x04020AD0 RID: 133840
		[Token(Token = "0x4020AD0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _txtAppellation;

		// Token: 0x04020AD1 RID: 133841
		[Token(Token = "0x4020AD1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _txtName;

		// Token: 0x04020AD2 RID: 133842
		[Token(Token = "0x4020AD2")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _animationLocation;

		// Token: 0x04020AD3 RID: 133843
		[Token(Token = "0x4020AD3")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x04020AD4 RID: 133844
		[Token(Token = "0x4020AD4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04020AD5 RID: 133845
		[Token(Token = "0x4020AD5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayNameShowAudio;

		// Token: 0x04020AD6 RID: 133846
		[Token(Token = "0x4020AD6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020041BE RID: 16830
		[Token(Token = "0x20041BE")]
		public class Option
		{
			// Token: 0x06019F30 RID: 106288 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019F30")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x04020AD7 RID: 133847
			[Token(Token = "0x4020AD7")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x04020AD8 RID: 133848
			[Token(Token = "0x4020AD8")]
			[FieldOffset(Offset = "0x18")]
			public string zoneId;
		}
	}
}
