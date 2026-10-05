using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005EC0 RID: 24256
	[Token(Token = "0x2005EC0")]
	public class CharacterLvlupPage : StateEnginePage
	{
		// Token: 0x060231FC RID: 143868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231FC")]
		[Address(RVA = "0x1DB5D50", Offset = "0x1DB4950", VA = "0x181DB5D50", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x060231FD RID: 143869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231FD")]
		[Address(RVA = "0x1DB6300", Offset = "0x1DB4F00", VA = "0x181DB6300")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060231FE RID: 143870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60231FE")]
		[Address(RVA = "0x1DB5AC0", Offset = "0x1DB46C0", VA = "0x181DB5AC0", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x060231FF RID: 143871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60231FF")]
		[Address(RVA = "0x1DB6420", Offset = "0x1DB5020", VA = "0x181DB6420")]
		private IEnumerator _RouteToProperState()
		{
			return null;
		}

		// Token: 0x06023200 RID: 143872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023200")]
		[Address(RVA = "0x1DB5EB0", Offset = "0x1DB4AB0", VA = "0x181DB5EB0")]
		private void _GenerateNormStack(ref List<StateCache> stack, CharacterLvlupPage.Param param)
		{
		}

		// Token: 0x06023201 RID: 143873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023201")]
		[Address(RVA = "0x1DB6100", Offset = "0x1DB4D00", VA = "0x181DB6100")]
		private void _GenerateSpOpStack(ref List<StateCache> stack)
		{
		}

		// Token: 0x06023202 RID: 143874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023202")]
		[Address(RVA = "0x1DB59E0", Offset = "0x1DB45E0", VA = "0x181DB59E0", Slot = "26")]
		protected override IEnumerator EffectsOnHide(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x06023203 RID: 143875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023203")]
		[Address(RVA = "0x1DB5B70", Offset = "0x1DB4770", VA = "0x181DB5B70")]
		public void OnExitFromLevelMaxState()
		{
		}

		// Token: 0x06023204 RID: 143876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023204")]
		[Address(RVA = "0x1DB64D0", Offset = "0x1DB50D0", VA = "0x181DB64D0")]
		public CharacterLvlupPage()
		{
		}

		// Token: 0x06023207 RID: 143879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023207")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x06023208 RID: 143880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023208")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x06023209 RID: 143881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023209")]
		[Address(RVA = "0x12172E0", Offset = "0x1215EE0", VA = "0x1812172E0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnHide(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x040306B9 RID: 198329
		[Token(Token = "0x40306B9")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _panelEffect;

		// Token: 0x040306BA RID: 198330
		[Token(Token = "0x40306BA")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_isInited;

		// Token: 0x040306BB RID: 198331
		[Token(Token = "0x40306BB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x040306BC RID: 198332
		[Token(Token = "0x40306BC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040306BD RID: 198333
		[Token(Token = "0x40306BD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x040306BE RID: 198334
		[Token(Token = "0x40306BE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RouteToProperState;

		// Token: 0x040306BF RID: 198335
		[Token(Token = "0x40306BF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GenerateNormStack;

		// Token: 0x040306C0 RID: 198336
		[Token(Token = "0x40306C0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenerateSpOpStack;

		// Token: 0x040306C1 RID: 198337
		[Token(Token = "0x40306C1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EffectsOnHide;

		// Token: 0x040306C2 RID: 198338
		[Token(Token = "0x40306C2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnExitFromLevelMaxState;

		// Token: 0x040306C3 RID: 198339
		[Token(Token = "0x40306C3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005EC1 RID: 24257
		[Token(Token = "0x2005EC1")]
		public class Param
		{
			// Token: 0x0602320A RID: 143882 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602320A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x040306C4 RID: 198340
			[Token(Token = "0x40306C4")]
			[FieldOffset(Offset = "0x10")]
			public bool isVoucherLevelMax;

			// Token: 0x040306C5 RID: 198341
			[Token(Token = "0x40306C5")]
			[FieldOffset(Offset = "0x11")]
			public bool isSpOp;

			// Token: 0x040306C6 RID: 198342
			[Token(Token = "0x40306C6")]
			[FieldOffset(Offset = "0x14")]
			public int charInstId;

			// Token: 0x040306C7 RID: 198343
			[Token(Token = "0x40306C7")]
			[FieldOffset(Offset = "0x18")]
			public string voucherItemId;

			// Token: 0x040306C8 RID: 198344
			[Token(Token = "0x40306C8")]
			[FieldOffset(Offset = "0x20")]
			public int voucherItemInstId;
		}
	}
}
