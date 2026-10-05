using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045BA RID: 17850
	[Token(Token = "0x20045BA")]
	public class RL03DifficultySelectLeftView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170040B7 RID: 16567
		// (get) Token: 0x0601B28A RID: 111242 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B28B RID: 111243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170040B7")]
		public Func<string, Sprite> buffIconLoader
		{
			[Token(Token = "0x601B28A")]
			[Address(RVA = "0x14492E0", Offset = "0x1447EE0", VA = "0x1814492E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B28B")]
			[Address(RVA = "0x1449340", Offset = "0x1447F40", VA = "0x181449340")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B28C RID: 111244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B28C")]
		[Address(RVA = "0x1448580", Offset = "0x1447180", VA = "0x181448580")]
		public void Render(RoguelikeTopicModeViewProperty property)
		{
		}

		// Token: 0x0601B28D RID: 111245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B28D")]
		[Address(RVA = "0x1448E10", Offset = "0x1447A10", VA = "0x181448E10")]
		private RoguelikeTopicDifficultyViewModel _FindBuffDifficultyModel(RoguelikeTopicModeViewModel model)
		{
			return null;
		}

		// Token: 0x0601B28E RID: 111246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B28E")]
		[Address(RVA = "0x1448EC0", Offset = "0x1447AC0", VA = "0x181448EC0")]
		private RoguelikeTopicDifficultyViewModel _FindDificultyModel(RoguelikeTopicModeViewModel model, RoguelikeTopicMode mode, int grade)
		{
			return null;
		}

		// Token: 0x0601B28F RID: 111247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B28F")]
		[Address(RVA = "0x14488F0", Offset = "0x14474F0", VA = "0x1814488F0")]
		public void UpdateSelect(RL03DifficultyViewModel difficulty, int selectIdx, bool fastMode)
		{
		}

		// Token: 0x0601B290 RID: 111248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B290")]
		[Address(RVA = "0x1448FF0", Offset = "0x1447BF0", VA = "0x181448FF0")]
		private void _TweenBuffIconTo(int buffCnt, bool fastMode)
		{
		}

		// Token: 0x0601B291 RID: 111249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B291")]
		[Address(RVA = "0x14483E0", Offset = "0x1446FE0", VA = "0x1814483E0")]
		public void EventShowAddDetail()
		{
		}

		// Token: 0x0601B292 RID: 111250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B292")]
		[Address(RVA = "0x14484B0", Offset = "0x14470B0", VA = "0x1814484B0")]
		public void EventShowRules()
		{
		}

		// Token: 0x0601B293 RID: 111251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B293")]
		[Address(RVA = "0x1449280", Offset = "0x1447E80", VA = "0x181449280")]
		public RL03DifficultySelectLeftView()
		{
		}

		// Token: 0x04022F96 RID: 143254
		[Token(Token = "0x4022F96")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _buffActiveBg;

		// Token: 0x04022F97 RID: 143255
		[Token(Token = "0x4022F97")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _buffDisactiveBg;

		// Token: 0x04022F98 RID: 143256
		[Token(Token = "0x4022F98")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _predictPanel;

		// Token: 0x04022F99 RID: 143257
		[Token(Token = "0x4022F99")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _buffPanel;

		// Token: 0x04022F9A RID: 143258
		[Token(Token = "0x4022F9A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _predictTips;

		// Token: 0x04022F9B RID: 143259
		[Token(Token = "0x4022F9B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _bpNum;

		// Token: 0x04022F9C RID: 143260
		[Token(Token = "0x4022F9C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _bossNum;

		// Token: 0x04022F9D RID: 143261
		[Token(Token = "0x4022F9D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _addRoot;

		// Token: 0x04022F9E RID: 143262
		[Token(Token = "0x4022F9E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _totemProb;

		// Token: 0x04022F9F RID: 143263
		[Token(Token = "0x4022F9F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _relicDevLevel;

		// Token: 0x04022FA0 RID: 143264
		[Token(Token = "0x4022FA0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image[] _buffIconImages;

		// Token: 0x04022FA1 RID: 143265
		[Token(Token = "0x4022FA1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Sprite _lockedBuffSprite;

		// Token: 0x04022FA2 RID: 143266
		[Token(Token = "0x4022FA2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _buffActiveTips;

		// Token: 0x04022FA3 RID: 143267
		[Token(Token = "0x4022FA3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _buffSwitchAnim;

		// Token: 0x04022FA4 RID: 143268
		[Token(Token = "0x4022FA4")]
		[FieldOffset(Offset = "0x90")]
		private RoguelikeTopicModeViewProperty m_cachedProp;

		// Token: 0x04022FA5 RID: 143269
		[Token(Token = "0x4022FA5")]
		[FieldOffset(Offset = "0x98")]
		private int m_currSel;

		// Token: 0x04022FA6 RID: 143270
		[Token(Token = "0x4022FA6")]
		[FieldOffset(Offset = "0x9C")]
		private float m_animPos;

		// Token: 0x04022FA7 RID: 143271
		[Token(Token = "0x4022FA7")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_animTween;

		// Token: 0x04022FA9 RID: 143273
		[Token(Token = "0x4022FA9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_buffIconLoader;

		// Token: 0x04022FAA RID: 143274
		[Token(Token = "0x4022FAA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_buffIconLoader;

		// Token: 0x04022FAB RID: 143275
		[Token(Token = "0x4022FAB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022FAC RID: 143276
		[Token(Token = "0x4022FAC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__FindBuffDifficultyModel;

		// Token: 0x04022FAD RID: 143277
		[Token(Token = "0x4022FAD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__FindDificultyModel;

		// Token: 0x04022FAE RID: 143278
		[Token(Token = "0x4022FAE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateSelect;

		// Token: 0x04022FAF RID: 143279
		[Token(Token = "0x4022FAF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TweenBuffIconTo;

		// Token: 0x04022FB0 RID: 143280
		[Token(Token = "0x4022FB0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventShowAddDetail;

		// Token: 0x04022FB1 RID: 143281
		[Token(Token = "0x4022FB1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventShowRules;

		// Token: 0x04022FB2 RID: 143282
		[Token(Token = "0x4022FB2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
