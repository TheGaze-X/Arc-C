using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005EC5 RID: 24261
	[Token(Token = "0x2005EC5")]
	public class CharacterPotentialPage : StateEnginePage
	{
		// Token: 0x0602321D RID: 143901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602321D")]
		[Address(RVA = "0x1DB72F0", Offset = "0x1DB5EF0", VA = "0x181DB72F0", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x0602321E RID: 143902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602321E")]
		[Address(RVA = "0x1DB7210", Offset = "0x1DB5E10", VA = "0x181DB7210", Slot = "26")]
		protected override IEnumerator EffectsOnHide(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x0602321F RID: 143903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602321F")]
		[Address(RVA = "0x1DB7450", Offset = "0x1DB6050", VA = "0x181DB7450")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023220 RID: 143904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023220")]
		[Address(RVA = "0x1DB7570", Offset = "0x1DB6170", VA = "0x181DB7570")]
		public CharacterPotentialPage()
		{
		}

		// Token: 0x06023222 RID: 143906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023222")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x06023223 RID: 143907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023223")]
		[Address(RVA = "0x12172E0", Offset = "0x1215EE0", VA = "0x1812172E0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnHide(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x040306D4 RID: 198356
		[Token(Token = "0x40306D4")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _panelEffect;

		// Token: 0x040306D5 RID: 198357
		[Token(Token = "0x40306D5")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_hasInited;

		// Token: 0x040306D6 RID: 198358
		[Token(Token = "0x40306D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x040306D7 RID: 198359
		[Token(Token = "0x40306D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EffectsOnHide;

		// Token: 0x040306D8 RID: 198360
		[Token(Token = "0x40306D8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040306D9 RID: 198361
		[Token(Token = "0x40306D9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005EC6 RID: 24262
		[Token(Token = "0x2005EC6")]
		public class Param
		{
			// Token: 0x06023224 RID: 143908 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023224")]
			[Address(RVA = "0x174F770", Offset = "0x174E370", VA = "0x18174F770")]
			public Param()
			{
			}

			// Token: 0x040306DA RID: 198362
			[Token(Token = "0x40306DA")]
			[FieldOffset(Offset = "0x10")]
			public int charInstId;

			// Token: 0x040306DB RID: 198363
			[Token(Token = "0x40306DB")]
			[FieldOffset(Offset = "0x14")]
			public bool showFadeInAnim;
		}
	}
}
