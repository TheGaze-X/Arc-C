using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053CF RID: 21455
	[Token(Token = "0x20053CF")]
	public class RoguelikeRewardCapsuleShowView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F939 RID: 129337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F939")]
		[Address(RVA = "0x1937FB0", Offset = "0x1936BB0", VA = "0x181937FB0")]
		public void Render(string topicId)
		{
		}

		// Token: 0x0601F93A RID: 129338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F93A")]
		[Address(RVA = "0x1938270", Offset = "0x1936E70", VA = "0x181938270")]
		public RoguelikeRewardCapsuleShowView()
		{
		}

		// Token: 0x0402A833 RID: 174131
		[Token(Token = "0x402A833")]
		private const string ANIM_NAME = "capsule_reward_anim";

		// Token: 0x0402A834 RID: 174132
		[Token(Token = "0x402A834")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _capsuleIcon;

		// Token: 0x0402A835 RID: 174133
		[Token(Token = "0x402A835")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x0402A836 RID: 174134
		[Token(Token = "0x402A836")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _usage;

		// Token: 0x0402A837 RID: 174135
		[Token(Token = "0x402A837")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _description;

		// Token: 0x0402A838 RID: 174136
		[Token(Token = "0x402A838")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationWrapper _animation;

		// Token: 0x0402A839 RID: 174137
		[Token(Token = "0x402A839")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A83A RID: 174138
		[Token(Token = "0x402A83A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
