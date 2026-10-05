using System;
using Il2CppDummyDll;
using Torappu.UI.TemplateCharSelect;
using Torappu.UI.TemplateCharSelect.Common;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.CharSelect
{
	// Token: 0x020063C9 RID: 25545
	[Token(Token = "0x20063C9")]
	public class AutoChessCharSelectState : PopupFadeState, ITemplateCharSelectCtrlHost
	{
		// Token: 0x170056F9 RID: 22265
		// (get) Token: 0x06024D50 RID: 150864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170056F9")]
		public TemplateCharSelectMainProperty prop
		{
			[Token(Token = "0x6024D50")]
			[Address(RVA = "0x1FBD490", Offset = "0x1FBC090", VA = "0x181FBD490", Slot = "31")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024D51 RID: 150865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D51")]
		[Address(RVA = "0x1FBCB90", Offset = "0x1FBB790", VA = "0x181FBCB90", Slot = "32")]
		public void Ensure()
		{
		}

		// Token: 0x06024D52 RID: 150866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D52")]
		[Address(RVA = "0x1FBCAE0", Offset = "0x1FBB6E0", VA = "0x181FBCAE0", Slot = "33")]
		public void Cancel()
		{
		}

		// Token: 0x06024D53 RID: 150867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D53")]
		[Address(RVA = "0x1FBCE50", Offset = "0x1FBBA50", VA = "0x181FBCE50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024D54 RID: 150868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D54")]
		[Address(RVA = "0x1FBCC10", Offset = "0x1FBB810", VA = "0x181FBCC10")]
		public void EventOnReturn()
		{
		}

		// Token: 0x06024D55 RID: 150869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D55")]
		[Address(RVA = "0x1FBCCF0", Offset = "0x1FBB8F0", VA = "0x181FBCCF0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06024D56 RID: 150870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D56")]
		[Address(RVA = "0x1FBCDD0", Offset = "0x1FBB9D0", VA = "0x181FBCDD0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06024D57 RID: 150871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024D57")]
		[Address(RVA = "0x1FBCC90", Offset = "0x1FBB890", VA = "0x181FBCC90", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06024D58 RID: 150872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D58")]
		[Address(RVA = "0x1FBD360", Offset = "0x1FBBF60", VA = "0x181FBD360")]
		public AutoChessCharSelectState()
		{
		}

		// Token: 0x06024D59 RID: 150873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D59")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06024D5A RID: 150874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D5A")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x040337EA RID: 210922
		[Token(Token = "0x40337EA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CommonCharSelectResHolder _resHolder;

		// Token: 0x040337EB RID: 210923
		[Token(Token = "0x40337EB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Button _backBtn;

		// Token: 0x040337EC RID: 210924
		[Token(Token = "0x40337EC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TemplateCharSelectController _controller;

		// Token: 0x040337ED RID: 210925
		[Token(Token = "0x40337ED")]
		[FieldOffset(Offset = "0x88")]
		private AutoChessCharSelectStateBean m_stateBean;

		// Token: 0x040337EE RID: 210926
		[Token(Token = "0x40337EE")]
		[FieldOffset(Offset = "0x90")]
		private bool m_inited;

		// Token: 0x040337EF RID: 210927
		[Token(Token = "0x40337EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x040337F0 RID: 210928
		[Token(Token = "0x40337F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Ensure;

		// Token: 0x040337F1 RID: 210929
		[Token(Token = "0x40337F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Cancel;

		// Token: 0x040337F2 RID: 210930
		[Token(Token = "0x40337F2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040337F3 RID: 210931
		[Token(Token = "0x40337F3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnReturn;

		// Token: 0x040337F4 RID: 210932
		[Token(Token = "0x40337F4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040337F5 RID: 210933
		[Token(Token = "0x40337F5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040337F6 RID: 210934
		[Token(Token = "0x40337F6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040337F7 RID: 210935
		[Token(Token = "0x40337F7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
