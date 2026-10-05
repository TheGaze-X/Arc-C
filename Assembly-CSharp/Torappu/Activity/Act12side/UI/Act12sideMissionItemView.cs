using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007AB4 RID: 31412
	[Token(Token = "0x2007AB4")]
	public class Act12sideMissionItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602C00B RID: 180235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C00B")]
		[Address(RVA = "0x27DF400", Offset = "0x27DE000", VA = "0x1827DF400")]
		public void Render(Act12sideMissionItemViewModel itemViewModel, float itemScale)
		{
		}

		// Token: 0x0602C00C RID: 180236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C00C")]
		[Address(RVA = "0x27DFD00", Offset = "0x27DE900", VA = "0x1827DFD00")]
		private void _UpdateCompleteStatus(bool isCompleted)
		{
		}

		// Token: 0x0602C00D RID: 180237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C00D")]
		[Address(RVA = "0x27DFE90", Offset = "0x27DEA90", VA = "0x1827DFE90")]
		public Act12sideMissionItemView()
		{
		}

		// Token: 0x0403FC04 RID: 261124
		[Token(Token = "0x403FC04")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act12sideMissionItemView.MissionStyleOption[] _styleOptions;

		// Token: 0x0403FC05 RID: 261125
		[Token(Token = "0x403FC05")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIScaler _scaler;

		// Token: 0x0403FC06 RID: 261126
		[Token(Token = "0x403FC06")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgBg;

		// Token: 0x0403FC07 RID: 261127
		[Token(Token = "0x403FC07")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgNote;

		// Token: 0x0403FC08 RID: 261128
		[Token(Token = "0x403FC08")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgCross;

		// Token: 0x0403FC09 RID: 261129
		[Token(Token = "0x403FC09")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textSpecialDesc;

		// Token: 0x0403FC0A RID: 261130
		[Token(Token = "0x403FC0A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textMissionDesc;

		// Token: 0x0403FC0B RID: 261131
		[Token(Token = "0x403FC0B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x0403FC0C RID: 261132
		[Token(Token = "0x403FC0C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textProgressCount;

		// Token: 0x0403FC0D RID: 261133
		[Token(Token = "0x403FC0D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Slider _sliderProgress;

		// Token: 0x0403FC0E RID: 261134
		[Token(Token = "0x403FC0E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _itemRoot;

		// Token: 0x0403FC0F RID: 261135
		[Token(Token = "0x403FC0F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _rewardScale;

		// Token: 0x0403FC10 RID: 261136
		[Token(Token = "0x403FC10")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Selectable _colorHandler;

		// Token: 0x0403FC11 RID: 261137
		[Token(Token = "0x403FC11")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _completedGo;

		// Token: 0x0403FC12 RID: 261138
		[Token(Token = "0x403FC12")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private TwoStateToggle _detailStateToggle;

		// Token: 0x0403FC13 RID: 261139
		[Token(Token = "0x403FC13")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textUnlockCaption;

		// Token: 0x0403FC14 RID: 261140
		[Token(Token = "0x403FC14")]
		[FieldOffset(Offset = "0x98")]
		private UIItemCard m_itemCard;

		// Token: 0x0403FC15 RID: 261141
		[Token(Token = "0x403FC15")]
		[FieldOffset(Offset = "0xA0")]
		private UIItemViewModel m_rewardViewModel;

		// Token: 0x0403FC16 RID: 261142
		[Token(Token = "0x403FC16")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403FC17 RID: 261143
		[Token(Token = "0x403FC17")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateCompleteStatus;

		// Token: 0x0403FC18 RID: 261144
		[Token(Token = "0x403FC18")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007AB5 RID: 31413
		[Token(Token = "0x2007AB5")]
		[Serializable]
		public struct MissionStyleOption
		{
			// Token: 0x0403FC19 RID: 261145
			[Token(Token = "0x403FC19")]
			[FieldOffset(Offset = "0x0")]
			public Act12SideData.ActZoneClass zoneClass;

			// Token: 0x0403FC1A RID: 261146
			[Token(Token = "0x403FC1A")]
			[FieldOffset(Offset = "0x8")]
			public Sprite spriteBg;

			// Token: 0x0403FC1B RID: 261147
			[Token(Token = "0x403FC1B")]
			[FieldOffset(Offset = "0x10")]
			public Sprite spriteNote;

			// Token: 0x0403FC1C RID: 261148
			[Token(Token = "0x403FC1C")]
			[FieldOffset(Offset = "0x18")]
			public Color colorCount;

			// Token: 0x0403FC1D RID: 261149
			[Token(Token = "0x403FC1D")]
			[FieldOffset(Offset = "0x28")]
			public Color colorCross;

			// Token: 0x0403FC1E RID: 261150
			[Token(Token = "0x403FC1E")]
			[FieldOffset(Offset = "0x38")]
			public Color colorSpecialDesc;

			// Token: 0x0403FC1F RID: 261151
			[Token(Token = "0x403FC1F")]
			[FieldOffset(Offset = "0x48")]
			public Color colorProgressCount;
		}
	}
}
