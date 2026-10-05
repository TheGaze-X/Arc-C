using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.Roguelike.Dice;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051F6 RID: 20982
	[Token(Token = "0x20051F6")]
	public class RoguelikeDiceView : DataBinder<RoguelikeDiceModelProperty>
	{
		// Token: 0x0601EF9C RID: 126876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF9C")]
		[Address(RVA = "0x18B42F0", Offset = "0x18B2EF0", VA = "0x1818B42F0")]
		public void InitIfNot(Transform diceSceneRoot)
		{
		}

		// Token: 0x0601EF9D RID: 126877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF9D")]
		[Address(RVA = "0x18B4490", Offset = "0x18B3090", VA = "0x1818B4490")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601EF9E RID: 126878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF9E")]
		[Address(RVA = "0x18B4540", Offset = "0x18B3140", VA = "0x1818B4540", Slot = "7")]
		public override void OnValueChanged(RoguelikeDiceModelProperty property)
		{
		}

		// Token: 0x0601EF9F RID: 126879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EF9F")]
		[Address(RVA = "0x18B3F60", Offset = "0x18B2B60", VA = "0x1818B3F60")]
		public RoguelikeDicePlugin GetPluginPrefab(Type typeOfPlugin)
		{
			return null;
		}

		// Token: 0x0601EFA0 RID: 126880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EFA0")]
		[Address(RVA = "0x18B4110", Offset = "0x18B2D10", VA = "0x1818B4110")]
		public Dictionary<DiceResultShowType, RoguelikeDiceResultViewBase.DiceResultViewModelCreator> GetSupportedResultViewModelCreators()
		{
			return null;
		}

		// Token: 0x0601EFA1 RID: 126881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EFA1")]
		[Address(RVA = "0x18B3E60", Offset = "0x18B2A60", VA = "0x1818B3E60")]
		public void EventOnCheck()
		{
		}

		// Token: 0x0601EFA2 RID: 126882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EFA2")]
		[Address(RVA = "0x18B3ED0", Offset = "0x18B2AD0", VA = "0x1818B3ED0")]
		public void EventOnReroll()
		{
		}

		// Token: 0x0601EFA3 RID: 126883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EFA3")]
		[Address(RVA = "0x18B4D20", Offset = "0x18B3920", VA = "0x1818B4D20")]
		public RoguelikeDiceView()
		{
		}

		// Token: 0x0402990B RID: 170251
		[Token(Token = "0x402990B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeDicePlugin[] _definedPlugins;

		// Token: 0x0402990C RID: 170252
		[Token(Token = "0x402990C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RoguelikeDiceResultViewBase[] _definedResultViews;

		// Token: 0x0402990D RID: 170253
		[Token(Token = "0x402990D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RoguelikeDiceView.ResultClassImage[] _resultSprites;

		// Token: 0x0402990E RID: 170254
		[Token(Token = "0x402990E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RoguelikeDiceGroup _diceScenePrefab;

		// Token: 0x0402990F RID: 170255
		[Token(Token = "0x402990F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _uiAnim;

		// Token: 0x04029910 RID: 170256
		[Token(Token = "0x4029910")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Font _numFont;

		// Token: 0x04029911 RID: 170257
		[Token(Token = "0x4029911")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _diceNum;

		// Token: 0x04029912 RID: 170258
		[Token(Token = "0x4029912")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _resultTag;

		// Token: 0x04029913 RID: 170259
		[Token(Token = "0x4029913")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _rerollBtn;

		// Token: 0x04029914 RID: 170260
		[Token(Token = "0x4029914")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _rerollBtnHot;

		// Token: 0x04029915 RID: 170261
		[Token(Token = "0x4029915")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _rerollCount;

		// Token: 0x04029916 RID: 170262
		[Token(Token = "0x4029916")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform _resultInfoRoot;

		// Token: 0x04029917 RID: 170263
		[Token(Token = "0x4029917")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Vector2 _renderTextureSize;

		// Token: 0x04029918 RID: 170264
		[Token(Token = "0x4029918")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RoguelikeEventRawImage _bg;

		// Token: 0x04029919 RID: 170265
		[Token(Token = "0x4029919")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		public Action onCheckBtnClick;

		// Token: 0x0402991A RID: 170266
		[Token(Token = "0x402991A")]
		[FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		public Action onRerollBtnClick;

		// Token: 0x0402991B RID: 170267
		[Token(Token = "0x402991B")]
		[FieldOffset(Offset = "0xA8")]
		private RoguelikeDiceGroup m_dice;

		// Token: 0x0402991C RID: 170268
		[Token(Token = "0x402991C")]
		[FieldOffset(Offset = "0xB0")]
		private RoguelikeDiceResultViewBase m_resultView;

		// Token: 0x0402991D RID: 170269
		[Token(Token = "0x402991D")]
		[FieldOffset(Offset = "0xB8")]
		private RenderTexture m_rt;

		// Token: 0x0402991E RID: 170270
		[Token(Token = "0x402991E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x0402991F RID: 170271
		[Token(Token = "0x402991F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04029920 RID: 170272
		[Token(Token = "0x4029920")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04029921 RID: 170273
		[Token(Token = "0x4029921")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetPluginPrefab;

		// Token: 0x04029922 RID: 170274
		[Token(Token = "0x4029922")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetSupportedResultViewModelCreators;

		// Token: 0x04029923 RID: 170275
		[Token(Token = "0x4029923")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnCheck;

		// Token: 0x04029924 RID: 170276
		[Token(Token = "0x4029924")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnReroll;

		// Token: 0x04029925 RID: 170277
		[Token(Token = "0x4029925")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020051F7 RID: 20983
		[Token(Token = "0x20051F7")]
		[Serializable]
		public class ResultClassImage
		{
			// Token: 0x0601EFA4 RID: 126884 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EFA4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ResultClassImage()
			{
			}

			// Token: 0x04029926 RID: 170278
			[Token(Token = "0x4029926")]
			[FieldOffset(Offset = "0x10")]
			public DiceResultClass type;

			// Token: 0x04029927 RID: 170279
			[Token(Token = "0x4029927")]
			[FieldOffset(Offset = "0x18")]
			public Sprite image;
		}
	}
}
