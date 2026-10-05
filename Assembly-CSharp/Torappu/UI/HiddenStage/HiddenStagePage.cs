using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HiddenStage
{
	// Token: 0x02004CA6 RID: 19622
	[Token(Token = "0x2004CA6")]
	public class HiddenStagePage : StateEnginePage
	{
		// Token: 0x17004501 RID: 17665
		// (get) Token: 0x0601D6A4 RID: 120484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004501")]
		public RectTransform decodeViewContainer
		{
			[Token(Token = "0x601D6A4")]
			[Address(RVA = "0x170AE50", Offset = "0x1709A50", VA = "0x18170AE50")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601D6A5 RID: 120485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6A5")]
		[Address(RVA = "0x170AD90", Offset = "0x1709990", VA = "0x18170AD90", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x0601D6A6 RID: 120486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6A6")]
		[Address(RVA = "0x170ADF0", Offset = "0x17099F0", VA = "0x18170ADF0")]
		public HiddenStagePage()
		{
		}

		// Token: 0x0601D6A7 RID: 120487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6A7")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x04026BCA RID: 158666
		[Token(Token = "0x4026BCA")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _decodeViewContainer;

		// Token: 0x04026BCB RID: 158667
		[Token(Token = "0x4026BCB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_decodeViewContainer;

		// Token: 0x04026BCC RID: 158668
		[Token(Token = "0x4026BCC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x04026BCD RID: 158669
		[Token(Token = "0x4026BCD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004CA7 RID: 19623
		[Token(Token = "0x2004CA7")]
		public class Params : IHotfixable
		{
			// Token: 0x0601D6A8 RID: 120488 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D6A8")]
			[Address(RVA = "0x170C710", Offset = "0x170B310", VA = "0x18170C710")]
			public Params()
			{
			}

			// Token: 0x04026BCE RID: 158670
			[Token(Token = "0x4026BCE")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x04026BCF RID: 158671
			[Token(Token = "0x4026BCF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
