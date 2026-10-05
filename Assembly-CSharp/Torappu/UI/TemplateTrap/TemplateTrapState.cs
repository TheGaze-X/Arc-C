using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateTrap
{
	// Token: 0x02003D31 RID: 15665
	[Token(Token = "0x2003D31")]
	public class TemplateTrapState : State
	{
		// Token: 0x06018690 RID: 99984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018690")]
		[Address(RVA = "0x10FCCD0", Offset = "0x10FB8D0", VA = "0x1810FCCD0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06018691 RID: 99985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018691")]
		[Address(RVA = "0x10FCD30", Offset = "0x10FB930", VA = "0x1810FCD30", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06018692 RID: 99986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018692")]
		[Address(RVA = "0x10FE190", Offset = "0x10FCD90", VA = "0x1810FE190")]
		private void _OnShowTween()
		{
		}

		// Token: 0x06018693 RID: 99987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018693")]
		[Address(RVA = "0x10FDFA0", Offset = "0x10FCBA0", VA = "0x1810FDFA0")]
		private void _OnSelectTrap(int index, string trapId)
		{
		}

		// Token: 0x06018694 RID: 99988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018694")]
		[Address(RVA = "0x10FDAF0", Offset = "0x10FC6F0", VA = "0x1810FDAF0")]
		private void _OnSaveTrapSquad()
		{
		}

		// Token: 0x06018695 RID: 99989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018695")]
		[Address(RVA = "0x10FD6D0", Offset = "0x10FC2D0", VA = "0x1810FD6D0")]
		private void _OnDirectSave(string trapId)
		{
		}

		// Token: 0x06018696 RID: 99990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018696")]
		[Address(RVA = "0x10FD5E0", Offset = "0x10FC1E0", VA = "0x1810FD5E0")]
		private void _OnBackClicked()
		{
		}

		// Token: 0x06018697 RID: 99991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018697")]
		[Address(RVA = "0x10FE290", Offset = "0x10FCE90", VA = "0x1810FE290")]
		public TemplateTrapState()
		{
		}

		// Token: 0x0601869A RID: 99994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601869A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0401DDC5 RID: 122309
		[Token(Token = "0x401DDC5")]
		[FieldOffset(Offset = "0x50")]
		private TemplateTrapStateBean m_trapStateBean;

		// Token: 0x0401DDC6 RID: 122310
		[Token(Token = "0x401DDC6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0401DDC7 RID: 122311
		[Token(Token = "0x401DDC7")]
		[FieldOffset(Offset = "0x60")]
		private TemplateTrapView m_trapView;

		// Token: 0x0401DDC8 RID: 122312
		[Token(Token = "0x401DDC8")]
		[FieldOffset(Offset = "0x68")]
		private Tween m_tween;

		// Token: 0x0401DDC9 RID: 122313
		[Token(Token = "0x401DDC9")]
		[FieldOffset(Offset = "0x70")]
		private TemplateTrapState.TemplateTrapSaveType m_trapSaveType;

		// Token: 0x0401DDCA RID: 122314
		[Token(Token = "0x401DDCA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401DDCB RID: 122315
		[Token(Token = "0x401DDCB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401DDCC RID: 122316
		[Token(Token = "0x401DDCC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnShowTween;

		// Token: 0x0401DDCD RID: 122317
		[Token(Token = "0x401DDCD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnSelectTrap;

		// Token: 0x0401DDCE RID: 122318
		[Token(Token = "0x401DDCE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnSaveTrapSquad;

		// Token: 0x0401DDCF RID: 122319
		[Token(Token = "0x401DDCF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnDirectSave;

		// Token: 0x0401DDD0 RID: 122320
		[Token(Token = "0x401DDD0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnBackClicked;

		// Token: 0x0401DDD1 RID: 122321
		[Token(Token = "0x401DDD1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003D32 RID: 15666
		[Token(Token = "0x2003D32")]
		public enum TemplateTrapSaveType
		{
			// Token: 0x0401DDD3 RID: 122323
			[Token(Token = "0x401DDD3")]
			NONE,
			// Token: 0x0401DDD4 RID: 122324
			[Token(Token = "0x401DDD4")]
			SELECT_AND_SAVE,
			// Token: 0x0401DDD5 RID: 122325
			[Token(Token = "0x401DDD5")]
			DIRECT_SAVE
		}

		// Token: 0x02003D33 RID: 15667
		[Token(Token = "0x2003D33")]
		public struct ActionConfig
		{
			// Token: 0x0401DDD6 RID: 122326
			[Token(Token = "0x401DDD6")]
			[FieldOffset(Offset = "0x0")]
			public Action<string, int> selectAction;

			// Token: 0x0401DDD7 RID: 122327
			[Token(Token = "0x401DDD7")]
			[FieldOffset(Offset = "0x8")]
			public Action saveAction;

			// Token: 0x0401DDD8 RID: 122328
			[Token(Token = "0x401DDD8")]
			[FieldOffset(Offset = "0x10")]
			public Action<string> directSaveAction;

			// Token: 0x0401DDD9 RID: 122329
			[Token(Token = "0x401DDD9")]
			[FieldOffset(Offset = "0x18")]
			public Action closeAction;
		}
	}
}
