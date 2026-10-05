using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02007014 RID: 28692
	[Token(Token = "0x2007014")]
	public class ActMultiV3TrainingRoomPage : StateEnginePage
	{
		// Token: 0x17006021 RID: 24609
		// (get) Token: 0x06028B94 RID: 166804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006021")]
		public string actId
		{
			[Token(Token = "0x6028B94")]
			[Address(RVA = "0x2416170", Offset = "0x2414D70", VA = "0x182416170")]
			get
			{
				return null;
			}
		}

		// Token: 0x06028B95 RID: 166805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B95")]
		[Address(RVA = "0x2416070", Offset = "0x2414C70", VA = "0x182416070", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06028B96 RID: 166806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028B96")]
		[Address(RVA = "0x2415FB0", Offset = "0x2414BB0", VA = "0x182415FB0", Slot = "25")]
		protected override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x06028B97 RID: 166807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028B97")]
		[Address(RVA = "0x2415ED0", Offset = "0x2414AD0", VA = "0x182415ED0", Slot = "26")]
		protected override IEnumerator EffectsOnHide(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x06028B98 RID: 166808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B98")]
		[Address(RVA = "0x2416110", Offset = "0x2414D10", VA = "0x182416110")]
		public ActMultiV3TrainingRoomPage()
		{
		}

		// Token: 0x06028B99 RID: 166809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B99")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06028B9A RID: 166810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028B9A")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x06028B9B RID: 166811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028B9B")]
		[Address(RVA = "0x12172E0", Offset = "0x1215EE0", VA = "0x1812172E0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnHide(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x0403A10E RID: 237838
		[Token(Token = "0x403A10E")]
		[FieldOffset(Offset = "0xF0")]
		private ActMultiV3TrainingRoomPage.Params m_param;

		// Token: 0x0403A10F RID: 237839
		[Token(Token = "0x403A10F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0403A110 RID: 237840
		[Token(Token = "0x403A110")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0403A111 RID: 237841
		[Token(Token = "0x403A111")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x0403A112 RID: 237842
		[Token(Token = "0x403A112")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EffectsOnHide;

		// Token: 0x0403A113 RID: 237843
		[Token(Token = "0x403A113")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007015 RID: 28693
		[Token(Token = "0x2007015")]
		public class Params
		{
			// Token: 0x06028B9C RID: 166812 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028B9C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x0403A114 RID: 237844
			[Token(Token = "0x403A114")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403A115 RID: 237845
			[Token(Token = "0x403A115")]
			[FieldOffset(Offset = "0x18")]
			public ActMultiV3MapModeType modeType;
		}
	}
}
