using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E22 RID: 20002
	[Token(Token = "0x2004E22")]
	public class FireworkGroupListRaycastLayer : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601DE24 RID: 122404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE24")]
		[Address(RVA = "0x1769AC0", Offset = "0x17686C0", VA = "0x181769AC0")]
		public void Render(FireworkPlateGroupModel groupModel)
		{
		}

		// Token: 0x0601DE25 RID: 122405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE25")]
		[Address(RVA = "0x1769A20", Offset = "0x1768620", VA = "0x181769A20")]
		public void OnBtnClicked()
		{
		}

		// Token: 0x0601DE26 RID: 122406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE26")]
		[Address(RVA = "0x1769B70", Offset = "0x1768770", VA = "0x181769B70")]
		public FireworkGroupListRaycastLayer()
		{
		}

		// Token: 0x04027A0B RID: 162315
		[Token(Token = "0x4027A0B")]
		[FieldOffset(Offset = "0x18")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04027A0C RID: 162316
		[Token(Token = "0x4027A0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027A0D RID: 162317
		[Token(Token = "0x4027A0D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnBtnClicked;

		// Token: 0x04027A0E RID: 162318
		[Token(Token = "0x4027A0E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
