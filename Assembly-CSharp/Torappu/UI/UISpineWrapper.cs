using System;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036E8 RID: 14056
	[Token(Token = "0x20036E8")]
	[RequireComponent(typeof(SkeletonGraphic))]
	public sealed class UISpineWrapper : MonoBehaviour, IHotfixable
	{
		// Token: 0x06016525 RID: 91429 RVA: 0x000908B8 File Offset: 0x0008EAB8
		[Token(Token = "0x6016525")]
		[Address(RVA = "0xED4BF0", Offset = "0xED37F0", VA = "0x180ED4BF0")]
		public bool Play(string spineName)
		{
			return default(bool);
		}

		// Token: 0x06016526 RID: 91430 RVA: 0x000908D0 File Offset: 0x0008EAD0
		[Token(Token = "0x6016526")]
		[Address(RVA = "0xED4CB0", Offset = "0xED38B0", VA = "0x180ED4CB0")]
		public bool Play(string spineName, SpineOptions option)
		{
			return default(bool);
		}

		// Token: 0x06016527 RID: 91431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016527")]
		[Address(RVA = "0xED4B90", Offset = "0xED3790", VA = "0x180ED4B90")]
		public void Awake()
		{
		}

		// Token: 0x06016528 RID: 91432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016528")]
		[Address(RVA = "0xED4E30", Offset = "0xED3A30", VA = "0x180ED4E30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06016529 RID: 91433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016529")]
		[Address(RVA = "0xED4EC0", Offset = "0xED3AC0", VA = "0x180ED4EC0")]
		public UISpineWrapper()
		{
		}

		// Token: 0x0401AD8C RID: 109964
		[Token(Token = "0x401AD8C")]
		[FieldOffset(Offset = "0x18")]
		private SkeletonGraphic m_target;

		// Token: 0x0401AD8D RID: 109965
		[Token(Token = "0x401AD8D")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isInited;

		// Token: 0x0401AD8E RID: 109966
		[Token(Token = "0x401AD8E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x0401AD8F RID: 109967
		[Token(Token = "0x401AD8F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_Play;

		// Token: 0x0401AD90 RID: 109968
		[Token(Token = "0x401AD90")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401AD91 RID: 109969
		[Token(Token = "0x401AD91")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401AD92 RID: 109970
		[Token(Token = "0x401AD92")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
