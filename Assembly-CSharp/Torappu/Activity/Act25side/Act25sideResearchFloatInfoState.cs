using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074F9 RID: 29945
	[Token(Token = "0x20074F9")]
	public class Act25sideResearchFloatInfoState : PopupFloatState
	{
		// Token: 0x0602A343 RID: 172867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A343")]
		[Address(RVA = "0x25CD0E0", Offset = "0x25CBCE0", VA = "0x1825CD0E0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602A344 RID: 172868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A344")]
		[Address(RVA = "0x25CD510", Offset = "0x25CC110", VA = "0x1825CD510")]
		private void _RenderInfo()
		{
		}

		// Token: 0x0602A345 RID: 172869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A345")]
		[Address(RVA = "0x25CD3E0", Offset = "0x25CBFE0", VA = "0x1825CD3E0")]
		private void _RenderHarvestRule(Act25SideData actData)
		{
		}

		// Token: 0x0602A346 RID: 172870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A346")]
		[Address(RVA = "0x25CD790", Offset = "0x25CC390", VA = "0x1825CD790")]
		private void _RenderTokenInfo(Act25SideData actData)
		{
		}

		// Token: 0x0602A347 RID: 172871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A347")]
		[Address(RVA = "0x25CD2C0", Offset = "0x25CBEC0", VA = "0x1825CD2C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A348 RID: 172872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A348")]
		[Address(RVA = "0x25CD140", Offset = "0x25CBD40", VA = "0x1825CD140", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602A349 RID: 172873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A349")]
		[Address(RVA = "0x25CD8C0", Offset = "0x25CC4C0", VA = "0x1825CD8C0")]
		public Act25sideResearchFloatInfoState()
		{
		}

		// Token: 0x0602A34A RID: 172874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A34A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403CA52 RID: 248402
		[Token(Token = "0x403CA52")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelToken;

		// Token: 0x0403CA53 RID: 248403
		[Token(Token = "0x403CA53")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelRule;

		// Token: 0x0403CA54 RID: 248404
		[Token(Token = "0x403CA54")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _ruleTitle;

		// Token: 0x0403CA55 RID: 248405
		[Token(Token = "0x403CA55")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _ruleDesc;

		// Token: 0x0403CA56 RID: 248406
		[Token(Token = "0x403CA56")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _tokenTitle;

		// Token: 0x0403CA57 RID: 248407
		[Token(Token = "0x403CA57")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _tokenDesc;

		// Token: 0x0403CA58 RID: 248408
		[Token(Token = "0x403CA58")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x0403CA59 RID: 248409
		[Token(Token = "0x403CA59")]
		[FieldOffset(Offset = "0xA8")]
		private Act25sideResearchFloatInfoStateBean m_cachedBean;

		// Token: 0x0403CA5A RID: 248410
		[Token(Token = "0x403CA5A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403CA5B RID: 248411
		[Token(Token = "0x403CA5B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderInfo;

		// Token: 0x0403CA5C RID: 248412
		[Token(Token = "0x403CA5C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderHarvestRule;

		// Token: 0x0403CA5D RID: 248413
		[Token(Token = "0x403CA5D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderTokenInfo;

		// Token: 0x0403CA5E RID: 248414
		[Token(Token = "0x403CA5E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CA5F RID: 248415
		[Token(Token = "0x403CA5F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403CA60 RID: 248416
		[Token(Token = "0x403CA60")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
