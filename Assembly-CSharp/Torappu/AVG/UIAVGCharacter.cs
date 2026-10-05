using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F10 RID: 7952
	[Token(Token = "0x2001F10")]
	public class UIAVGCharacter : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600C549 RID: 50505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C549")]
		[Address(RVA = "0x3436700", Offset = "0x3435300", VA = "0x183436700")]
		public void SetCharacter(AVGSharedCharacter.Option option)
		{
		}

		// Token: 0x0600C54A RID: 50506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C54A")]
		[Address(RVA = "0x34366A0", Offset = "0x34352A0", VA = "0x1834366A0")]
		public void OnDestroy()
		{
		}

		// Token: 0x0600C54B RID: 50507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C54B")]
		[Address(RVA = "0x3436860", Offset = "0x3435460", VA = "0x183436860")]
		private void _LoadCharacter(AVGSharedCharacter.Option option)
		{
		}

		// Token: 0x0600C54C RID: 50508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C54C")]
		[Address(RVA = "0x3436C20", Offset = "0x3435820", VA = "0x183436C20")]
		private void _UnloadCharacter()
		{
		}

		// Token: 0x0600C54D RID: 50509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C54D")]
		[Address(RVA = "0x3436AE0", Offset = "0x34356E0", VA = "0x183436AE0")]
		private GameObject _LoadHub(string path)
		{
			return null;
		}

		// Token: 0x0600C54E RID: 50510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C54E")]
		[Address(RVA = "0x3436E30", Offset = "0x3435A30", VA = "0x183436E30")]
		public UIAVGCharacter()
		{
		}

		// Token: 0x0400C9F8 RID: 51704
		[Token(Token = "0x400C9F8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0400C9F9 RID: 51705
		[Token(Token = "0x400C9F9")]
		[FieldOffset(Offset = "0x20")]
		private AVGSharedCharacter m_cachedCharacter;

		// Token: 0x0400C9FA RID: 51706
		[Token(Token = "0x400C9FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetCharacter;

		// Token: 0x0400C9FB RID: 51707
		[Token(Token = "0x400C9FB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400C9FC RID: 51708
		[Token(Token = "0x400C9FC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadCharacter;

		// Token: 0x0400C9FD RID: 51709
		[Token(Token = "0x400C9FD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UnloadCharacter;

		// Token: 0x0400C9FE RID: 51710
		[Token(Token = "0x400C9FE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadHub;

		// Token: 0x0400C9FF RID: 51711
		[Token(Token = "0x400C9FF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
