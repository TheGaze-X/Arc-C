using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200562F RID: 22063
	[Token(Token = "0x200562F")]
	public class RL05SpecialZoneNodeViewData : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020619 RID: 132633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020619")]
		[Address(RVA = "0x1A86570", Offset = "0x1A85170", VA = "0x181A86570")]
		public Sprite FindSprite(string name)
		{
			return null;
		}

		// Token: 0x0602061A RID: 132634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602061A")]
		[Address(RVA = "0x1A86450", Offset = "0x1A85050", VA = "0x181A86450")]
		public GameObject FindRepeatableEffect(string effectName)
		{
			return null;
		}

		// Token: 0x0602061B RID: 132635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602061B")]
		[Address(RVA = "0x1A86690", Offset = "0x1A85290", VA = "0x181A86690")]
		public RL05SpecialZoneNodeViewData()
		{
		}

		// Token: 0x0402BD69 RID: 179561
		[Token(Token = "0x402BD69")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[ReadOnly]
		private Sprite[] _iconSprites;

		// Token: 0x0402BD6A RID: 179562
		[Token(Token = "0x402BD6A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] _repeatableEffects;

		// Token: 0x0402BD6B RID: 179563
		[Token(Token = "0x402BD6B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FindSprite;

		// Token: 0x0402BD6C RID: 179564
		[Token(Token = "0x402BD6C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FindRepeatableEffect;

		// Token: 0x0402BD6D RID: 179565
		[Token(Token = "0x402BD6D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
