using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055E8 RID: 21992
	[Token(Token = "0x20055E8")]
	public class RL05MenuCopperListWindowCopperView : MonoBehaviour
	{
		// Token: 0x06020495 RID: 132245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020495")]
		[Address(RVA = "0x1A62A60", Offset = "0x1A61660", VA = "0x181A62A60")]
		public void Render(RoguelikePlayerCopperItemViewModel viewModel, string topicId, ILoadAsset loader)
		{
		}

		// Token: 0x06020496 RID: 132246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020496")]
		[Address(RVA = "0x1A62DE0", Offset = "0x1A619E0", VA = "0x181A62DE0")]
		public RL05MenuCopperListWindowCopperView()
		{
		}

		// Token: 0x0402BAF9 RID: 178937
		[Token(Token = "0x402BAF9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _copperItemCardScale;

		// Token: 0x0402BAFA RID: 178938
		[Token(Token = "0x402BAFA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _copperCardContainer;

		// Token: 0x0402BAFB RID: 178939
		[Token(Token = "0x402BAFB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtName;

		// Token: 0x0402BAFC RID: 178940
		[Token(Token = "0x402BAFC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgLuckyIcon;

		// Token: 0x0402BAFD RID: 178941
		[Token(Token = "0x402BAFD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtCountDown;

		// Token: 0x0402BAFE RID: 178942
		[Token(Token = "0x402BAFE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtDescription;

		// Token: 0x0402BAFF RID: 178943
		[Token(Token = "0x402BAFF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _objDrawnStatus;

		// Token: 0x0402BB00 RID: 178944
		[Token(Token = "0x402BB00")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikeCopperResHolder m_copperResHolder;

		// Token: 0x0402BB01 RID: 178945
		[Token(Token = "0x402BB01")]
		[FieldOffset(Offset = "0x58")]
		private RoguelikeAbstractCopperItemCard m_copperCard;

		// Token: 0x0402BB02 RID: 178946
		[Token(Token = "0x402BB02")]
		[FieldOffset(Offset = "0x60")]
		private RoguelikePlayerCopperItemViewModel m_viewModel;

		// Token: 0x0402BB03 RID: 178947
		[Token(Token = "0x402BB03")]
		[FieldOffset(Offset = "0x68")]
		private string m_topicId;
	}
}
