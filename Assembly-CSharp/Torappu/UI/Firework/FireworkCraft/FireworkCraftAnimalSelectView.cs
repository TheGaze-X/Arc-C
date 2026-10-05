using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Firework.FireworkCraft
{
	// Token: 0x02004E7A RID: 20090
	[Token(Token = "0x2004E7A")]
	public class FireworkCraftAnimalSelectView : DataBinder<FireworkCraftAnimalSelectProperty>
	{
		// Token: 0x17004661 RID: 18017
		// (get) Token: 0x0601DFC1 RID: 122817 RVA: 0x000AD160 File Offset: 0x000AB360
		[Token(Token = "0x17004661")]
		public bool isPlayingEnterAnim
		{
			[Token(Token = "0x601DFC1")]
			[Address(RVA = "0x179C620", Offset = "0x179B220", VA = "0x18179C620")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601DFC2 RID: 122818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFC2")]
		[Address(RVA = "0x179BFF0", Offset = "0x179ABF0", VA = "0x18179BFF0", Slot = "7")]
		public override void OnValueChanged(FireworkCraftAnimalSelectProperty property)
		{
		}

		// Token: 0x0601DFC3 RID: 122819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFC3")]
		[Address(RVA = "0x179C4F0", Offset = "0x179B0F0", VA = "0x18179C4F0")]
		public void RegisterTutorialGo()
		{
		}

		// Token: 0x0601DFC4 RID: 122820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFC4")]
		[Address(RVA = "0x179BF40", Offset = "0x179AB40", VA = "0x18179BF40")]
		public void OnEquipBtnClicked()
		{
		}

		// Token: 0x0601DFC5 RID: 122821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFC5")]
		[Address(RVA = "0x179C5B0", Offset = "0x179B1B0", VA = "0x18179C5B0")]
		public FireworkCraftAnimalSelectView()
		{
		}

		// Token: 0x04027D2E RID: 163118
		[Token(Token = "0x4027D2E")]
		private const string LEFT_SPINE_ANIM_NAME = "entry_left";

		// Token: 0x04027D2F RID: 163119
		[Token(Token = "0x4027D2F")]
		private const string RIGHT_SPINE_ANIM_NAME = "entry_right";

		// Token: 0x04027D30 RID: 163120
		[Token(Token = "0x4027D30")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FireworkCraftAnimalSelectAnimalView[] _animalViews;

		// Token: 0x04027D31 RID: 163121
		[Token(Token = "0x4027D31")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgSelectedAnimal;

		// Token: 0x04027D32 RID: 163122
		[Token(Token = "0x4027D32")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textSelectedAnimalDesc;

		// Token: 0x04027D33 RID: 163123
		[Token(Token = "0x4027D33")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _pnlEquip;

		// Token: 0x04027D34 RID: 163124
		[Token(Token = "0x4027D34")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _pnlAlreadyEquiped;

		// Token: 0x04027D35 RID: 163125
		[Token(Token = "0x4027D35")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x04027D36 RID: 163126
		[Token(Token = "0x4027D36")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _btnAnimal;

		// Token: 0x04027D37 RID: 163127
		[Token(Token = "0x4027D37")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UISpineWrapper _spineWrapperLeft;

		// Token: 0x04027D38 RID: 163128
		[Token(Token = "0x4027D38")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UISpineWrapper _spineWrapperRight;

		// Token: 0x04027D39 RID: 163129
		[Token(Token = "0x4027D39")]
		[FieldOffset(Offset = "0x70")]
		private string m_cachedSelectedAnimal;

		// Token: 0x04027D3A RID: 163130
		[Token(Token = "0x4027D3A")]
		[FieldOffset(Offset = "0x78")]
		private int m_cachedLoadSeqNum;

		// Token: 0x04027D3B RID: 163131
		[Token(Token = "0x4027D3B")]
		[FieldOffset(Offset = "0x80")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04027D3C RID: 163132
		[Token(Token = "0x4027D3C")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_showTween;

		// Token: 0x04027D3D RID: 163133
		[Token(Token = "0x4027D3D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isPlayingEnterAnim;

		// Token: 0x04027D3E RID: 163134
		[Token(Token = "0x4027D3E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04027D3F RID: 163135
		[Token(Token = "0x4027D3F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGo;

		// Token: 0x04027D40 RID: 163136
		[Token(Token = "0x4027D40")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEquipBtnClicked;

		// Token: 0x04027D41 RID: 163137
		[Token(Token = "0x4027D41")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
