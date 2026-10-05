using System;
using Il2CppDummyDll;
using Torappu.AsyncLoader;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054A7 RID: 21671
	[Token(Token = "0x20054A7")]
	public class RoguelikeCommonCharHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601FE28 RID: 130600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE28")]
		[Address(RVA = "0x1A03E80", Offset = "0x1A02A80", VA = "0x181A03E80")]
		public void UpdateStatus(int index, RoguelikeCharCommonCharView.AsyncParam param, AsyncGameObjectLoader loader)
		{
		}

		// Token: 0x0601FE29 RID: 130601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE29")]
		[Address(RVA = "0x1A04050", Offset = "0x1A02C50", VA = "0x181A04050")]
		public RoguelikeCommonCharHolder()
		{
		}

		// Token: 0x0402AFF8 RID: 176120
		[Token(Token = "0x402AFF8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeCharCommonCharView _prefab;

		// Token: 0x0402AFF9 RID: 176121
		[Token(Token = "0x402AFF9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0402AFFA RID: 176122
		[Token(Token = "0x402AFFA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private uint _costPerObj;

		// Token: 0x0402AFFB RID: 176123
		[Token(Token = "0x402AFFB")]
		[FieldOffset(Offset = "0x30")]
		private AsyncDataViewHandler<RoguelikeCharCommonCharView, RoguelikeCharCommonCharView.AsyncParam> m_handler;

		// Token: 0x0402AFFC RID: 176124
		[Token(Token = "0x402AFFC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateStatus;

		// Token: 0x0402AFFD RID: 176125
		[Token(Token = "0x402AFFD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
