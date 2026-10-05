using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005553 RID: 21843
	[Token(Token = "0x2005553")]
	public class RoguelikeTaskCompleteView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004B63 RID: 19299
		// (get) Token: 0x060201EC RID: 131564 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060201ED RID: 131565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004B63")]
		public Action onGetReward
		{
			[Token(Token = "0x60201EC")]
			[Address(RVA = "0x1A44F80", Offset = "0x1A43B80", VA = "0x181A44F80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60201ED")]
			[Address(RVA = "0x1A44FE0", Offset = "0x1A43BE0", VA = "0x181A44FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060201EE RID: 131566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201EE")]
		[Address(RVA = "0x1A44B40", Offset = "0x1A43740", VA = "0x181A44B40")]
		public void Render(RoguelikeTaskCompleteModel taskModel)
		{
		}

		// Token: 0x060201EF RID: 131567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201EF")]
		[Address(RVA = "0x1A44A30", Offset = "0x1A43630", VA = "0x181A44A30")]
		public void OnBtnGetReward()
		{
		}

		// Token: 0x060201F0 RID: 131568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201F0")]
		[Address(RVA = "0x1A44F10", Offset = "0x1A43B10", VA = "0x181A44F10")]
		public RoguelikeTaskCompleteView()
		{
		}

		// Token: 0x0402B63E RID: 177726
		[Token(Token = "0x402B63E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textProgress;

		// Token: 0x0402B63F RID: 177727
		[Token(Token = "0x402B63F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _alphaComplted;

		// Token: 0x0402B640 RID: 177728
		[Token(Token = "0x402B640")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Slider _sliderProgress;

		// Token: 0x0402B641 RID: 177729
		[Token(Token = "0x402B641")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textTaskName;

		// Token: 0x0402B642 RID: 177730
		[Token(Token = "0x402B642")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textTaskDesc;

		// Token: 0x0402B643 RID: 177731
		[Token(Token = "0x402B643")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _imgRarity;

		// Token: 0x0402B644 RID: 177732
		[Token(Token = "0x402B644")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasObject _atlas;

		// Token: 0x0402B646 RID: 177734
		[Token(Token = "0x402B646")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onGetReward;

		// Token: 0x0402B647 RID: 177735
		[Token(Token = "0x402B647")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onGetReward;

		// Token: 0x0402B648 RID: 177736
		[Token(Token = "0x402B648")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B649 RID: 177737
		[Token(Token = "0x402B649")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBtnGetReward;

		// Token: 0x0402B64A RID: 177738
		[Token(Token = "0x402B64A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
