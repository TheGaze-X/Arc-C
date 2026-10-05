using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043B1 RID: 17329
	[Token(Token = "0x20043B1")]
	public class SandboxV2NotificactionView : UINotifyView<SandboxV2NotificactionView.Param>
	{
		// Token: 0x0601A95B RID: 108891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A95B")]
		[Address(RVA = "0x13AC010", Offset = "0x13AAC10", VA = "0x1813AC010", Slot = "9")]
		protected override void Render(SandboxV2NotificactionView.Param param)
		{
		}

		// Token: 0x0601A95C RID: 108892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A95C")]
		[Address(RVA = "0x13AC170", Offset = "0x13AAD70", VA = "0x1813AC170")]
		public SandboxV2NotificactionView()
		{
		}

		// Token: 0x04021DFA RID: 138746
		[Token(Token = "0x4021DFA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SandboxV2NotificactionView.Config[] _configList;

		// Token: 0x04021DFB RID: 138747
		[Token(Token = "0x4021DFB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04021DFC RID: 138748
		[Token(Token = "0x4021DFC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021DFD RID: 138749
		[Token(Token = "0x4021DFD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020043B2 RID: 17330
		[Token(Token = "0x20043B2")]
		public class Param : NotifyViewParam
		{
			// Token: 0x0601A95D RID: 108893 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A95D")]
			[Address(RVA = "0x13A73B0", Offset = "0x13A5FB0", VA = "0x1813A73B0", Slot = "4")]
			public override string GenerateSignature()
			{
				return null;
			}

			// Token: 0x0601A95E RID: 108894 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A95E")]
			[Address(RVA = "0x13A7560", Offset = "0x13A6160", VA = "0x1813A7560")]
			public Param()
			{
			}

			// Token: 0x04021DFE RID: 138750
			[Token(Token = "0x4021DFE")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2Const.SandboxV2ToastType type;

			// Token: 0x04021DFF RID: 138751
			[Token(Token = "0x4021DFF")]
			[FieldOffset(Offset = "0x18")]
			public string desc;

			// Token: 0x04021E00 RID: 138752
			[Token(Token = "0x4021E00")]
			[FieldOffset(Offset = "0x20")]
			public bool useDeduplicate;
		}

		// Token: 0x020043B3 RID: 17331
		[Token(Token = "0x20043B3")]
		[Serializable]
		public struct Config
		{
			// Token: 0x04021E01 RID: 138753
			[Token(Token = "0x4021E01")]
			[FieldOffset(Offset = "0x0")]
			public SandboxV2Const.SandboxV2ToastType type;

			// Token: 0x04021E02 RID: 138754
			[Token(Token = "0x4021E02")]
			[FieldOffset(Offset = "0x8")]
			public GameObject panelIcon;
		}
	}
}
