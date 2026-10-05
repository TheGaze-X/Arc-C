using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004979 RID: 18809
	[Token(Token = "0x2004979")]
	public class MedalBarListStateBtn : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C58A RID: 116106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C58A")]
		[Address(RVA = "0x15C5ED0", Offset = "0x15C4AD0", VA = "0x1815C5ED0")]
		public void SetState(MedalBarListShowType showType)
		{
		}

		// Token: 0x0601C58B RID: 116107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C58B")]
		[Address(RVA = "0x15C5F60", Offset = "0x15C4B60", VA = "0x1815C5F60")]
		public MedalBarListStateBtn()
		{
		}

		// Token: 0x04025186 RID: 151942
		[Token(Token = "0x4025186")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _stateToggle;

		// Token: 0x04025187 RID: 151943
		[Token(Token = "0x4025187")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MedalBarListShowType _showType;

		// Token: 0x04025188 RID: 151944
		[Token(Token = "0x4025188")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetState;

		// Token: 0x04025189 RID: 151945
		[Token(Token = "0x4025189")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
