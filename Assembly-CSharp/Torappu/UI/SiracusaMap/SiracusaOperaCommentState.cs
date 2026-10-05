using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F38 RID: 16184
	[Token(Token = "0x2003F38")]
	public class SiracusaOperaCommentState : PopupFadeState
	{
		// Token: 0x0601922C RID: 102956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601922C")]
		[Address(RVA = "0x11D94B0", Offset = "0x11D80B0", VA = "0x1811D94B0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601922D RID: 102957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601922D")]
		[Address(RVA = "0x11D9590", Offset = "0x11D8190", VA = "0x1811D9590", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601922E RID: 102958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601922E")]
		[Address(RVA = "0x11D9510", Offset = "0x11D8110", VA = "0x1811D9510", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601922F RID: 102959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601922F")]
		[Address(RVA = "0x11D9600", Offset = "0x11D8200", VA = "0x1811D9600", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06019230 RID: 102960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019230")]
		[Address(RVA = "0x11D9D10", Offset = "0x11D8910", VA = "0x1811D9D10")]
		private void _OnReward(IStateBean stateBean)
		{
		}

		// Token: 0x06019231 RID: 102961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019231")]
		[Address(RVA = "0x11D9760", Offset = "0x11D8360", VA = "0x1811D9760")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019232 RID: 102962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019232")]
		[Address(RVA = "0x11D9E10", Offset = "0x11D8A10", VA = "0x1811D9E10")]
		private void _UpdateProp(bool isInit = false)
		{
		}

		// Token: 0x06019233 RID: 102963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019233")]
		[Address(RVA = "0x11D9920", Offset = "0x11D8520", VA = "0x1811D9920")]
		private void _LikeComment(string commentId)
		{
		}

		// Token: 0x06019234 RID: 102964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019234")]
		[Address(RVA = "0x11D9290", Offset = "0x11D7E90", VA = "0x1811D9290")]
		public void EventOnCommentLiked(string commentId)
		{
		}

		// Token: 0x06019235 RID: 102965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019235")]
		[Address(RVA = "0x11D9F30", Offset = "0x11D8B30", VA = "0x1811D9F30")]
		public SiracusaOperaCommentState()
		{
		}

		// Token: 0x06019236 RID: 102966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019236")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06019237 RID: 102967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019237")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06019238 RID: 102968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019238")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0401F225 RID: 127525
		[Token(Token = "0x401F225")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SiracusaOperaCommentView _view;

		// Token: 0x0401F226 RID: 127526
		[Token(Token = "0x401F226")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0401F227 RID: 127527
		[Token(Token = "0x401F227")]
		[FieldOffset(Offset = "0x80")]
		private SiracusaOperaCommentStateBean m_stateBean;

		// Token: 0x0401F228 RID: 127528
		[Token(Token = "0x401F228")]
		[FieldOffset(Offset = "0x88")]
		private string m_cachedGroupId;

		// Token: 0x0401F229 RID: 127529
		[Token(Token = "0x401F229")]
		[FieldOffset(Offset = "0x90")]
		private string m_cachedCharCardId;

		// Token: 0x0401F22A RID: 127530
		[Token(Token = "0x401F22A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401F22B RID: 127531
		[Token(Token = "0x401F22B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401F22C RID: 127532
		[Token(Token = "0x401F22C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401F22D RID: 127533
		[Token(Token = "0x401F22D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0401F22E RID: 127534
		[Token(Token = "0x401F22E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnReward;

		// Token: 0x0401F22F RID: 127535
		[Token(Token = "0x401F22F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F230 RID: 127536
		[Token(Token = "0x401F230")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateProp;

		// Token: 0x0401F231 RID: 127537
		[Token(Token = "0x401F231")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LikeComment;

		// Token: 0x0401F232 RID: 127538
		[Token(Token = "0x401F232")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnCommentLiked;

		// Token: 0x0401F233 RID: 127539
		[Token(Token = "0x401F233")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
