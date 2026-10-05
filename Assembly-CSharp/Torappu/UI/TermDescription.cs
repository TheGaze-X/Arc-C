using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B75 RID: 15221
	[Token(Token = "0x2003B75")]
	public class TermDescription : SingletonMonoBehaviour<TermDescription>, ISingletonNotAutoCreate, ILuaCallCSharp, IHotfixable
	{
		// Token: 0x06017DD7 RID: 97751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DD7")]
		[Address(RVA = "0x10211C0", Offset = "0x101FDC0", VA = "0x1810211C0", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x06017DD8 RID: 97752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DD8")]
		[Address(RVA = "0x1021150", Offset = "0x101FD50", VA = "0x181021150", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06017DD9 RID: 97753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DD9")]
		[Address(RVA = "0x1021230", Offset = "0x101FE30", VA = "0x181021230")]
		public void ShowTermDesc(UITermDescDataModel valuePair)
		{
		}

		// Token: 0x06017DDA RID: 97754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DDA")]
		[Address(RVA = "0x1021700", Offset = "0x1020300", VA = "0x181021700")]
		private void _InitTermDescViewIfNeeded()
		{
		}

		// Token: 0x06017DDB RID: 97755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DDB")]
		[Address(RVA = "0x10218D0", Offset = "0x10204D0", VA = "0x1810218D0")]
		public TermDescription()
		{
		}

		// Token: 0x0401CD5A RID: 118106
		[Token(Token = "0x401CD5A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform termDesciptionRoot;

		// Token: 0x0401CD5B RID: 118107
		[Token(Token = "0x401CD5B")]
		[FieldOffset(Offset = "0x0")]
		private static TermDescriptionView m_cachedTermDescView;

		// Token: 0x0401CD5C RID: 118108
		[Token(Token = "0x401CD5C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401CD5D RID: 118109
		[Token(Token = "0x401CD5D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401CD5E RID: 118110
		[Token(Token = "0x401CD5E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowTermDesc;

		// Token: 0x0401CD5F RID: 118111
		[Token(Token = "0x401CD5F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitTermDescViewIfNeeded;

		// Token: 0x0401CD60 RID: 118112
		[Token(Token = "0x401CD60")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
