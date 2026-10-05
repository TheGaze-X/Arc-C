using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.CharacterInfo;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x020048AD RID: 18605
	[Token(Token = "0x20048AD")]
	public class SoCharMissionRightPart : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C129 RID: 114985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C129")]
		[Address(RVA = "0x1572400", Offset = "0x1571000", VA = "0x181572400")]
		private void _InitAdapterIfNot()
		{
		}

		// Token: 0x170042A4 RID: 17060
		// (get) Token: 0x0601C12A RID: 114986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042A4")]
		public Transform targetPos
		{
			[Token(Token = "0x601C12A")]
			[Address(RVA = "0x1572790", Offset = "0x1571390", VA = "0x181572790")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C12B RID: 114987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C12B")]
		[Address(RVA = "0x1572550", Offset = "0x1571150", VA = "0x181572550")]
		private void _RenderNoPart(CharQuery charQuery)
		{
		}

		// Token: 0x0601C12C RID: 114988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C12C")]
		[Address(RVA = "0x1572330", Offset = "0x1570F30", VA = "0x181572330")]
		public void RenderMission(List<MissionViewModel> missionModels)
		{
		}

		// Token: 0x0601C12D RID: 114989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C12D")]
		[Address(RVA = "0x1571DD0", Offset = "0x15709D0", VA = "0x181571DD0")]
		public void RenderExp(CharacterData charData, int exp, int level, int maxExp)
		{
		}

		// Token: 0x0601C12E RID: 114990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C12E")]
		[Address(RVA = "0x1571A00", Offset = "0x1570600", VA = "0x181571A00")]
		public void RenderChar(CharQuery charId, PlayerCharacter charInfo, CharacterData charData)
		{
		}

		// Token: 0x0601C12F RID: 114991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C12F")]
		[Address(RVA = "0x1572730", Offset = "0x1571330", VA = "0x181572730")]
		public SoCharMissionRightPart()
		{
		}

		// Token: 0x04024AB8 RID: 150200
		[Token(Token = "0x4024AB8")]
		private const float DURATION = 0.15f;

		// Token: 0x04024AB9 RID: 150201
		[Token(Token = "0x4024AB9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _eliteImg;

		// Token: 0x04024ABA RID: 150202
		[Token(Token = "0x4024ABA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _currentLvl;

		// Token: 0x04024ABB RID: 150203
		[Token(Token = "0x4024ABB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _maxLvl;

		// Token: 0x04024ABC RID: 150204
		[Token(Token = "0x4024ABC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _expText;

		// Token: 0x04024ABD RID: 150205
		[Token(Token = "0x4024ABD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04024ABE RID: 150206
		[Token(Token = "0x4024ABE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _charAvailPart;

		// Token: 0x04024ABF RID: 150207
		[Token(Token = "0x4024ABF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _fillPart;

		// Token: 0x04024AC0 RID: 150208
		[Token(Token = "0x4024AC0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _targetExp;

		// Token: 0x04024AC1 RID: 150209
		[Token(Token = "0x4024AC1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _potentialImg;

		// Token: 0x04024AC2 RID: 150210
		[Token(Token = "0x4024AC2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _potentialBackImg;

		// Token: 0x04024AC3 RID: 150211
		[Token(Token = "0x4024AC3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _exp;

		// Token: 0x04024AC4 RID: 150212
		[Token(Token = "0x4024AC4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _maxAllLvl;

		// Token: 0x04024AC5 RID: 150213
		[Token(Token = "0x4024AC5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _maxHint;

		// Token: 0x04024AC6 RID: 150214
		[Token(Token = "0x4024AC6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _charMissionPart;

		// Token: 0x04024AC7 RID: 150215
		[Token(Token = "0x4024AC7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _noCharPart;

		// Token: 0x04024AC8 RID: 150216
		[Token(Token = "0x4024AC8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _hasCharFullLvlPart;

		// Token: 0x04024AC9 RID: 150217
		[Token(Token = "0x4024AC9")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _hasCharAllFullPart;

		// Token: 0x04024ACA RID: 150218
		[Token(Token = "0x4024ACA")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIParticle _effectLvl;

		// Token: 0x04024ACB RID: 150219
		[Token(Token = "0x4024ACB")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image _typeImg;

		// Token: 0x04024ACC RID: 150220
		[Token(Token = "0x4024ACC")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _typeText;

		// Token: 0x04024ACD RID: 150221
		[Token(Token = "0x4024ACD")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private CharacterInfoLevelUpNotifyView _levelUpNotify;

		// Token: 0x04024ACE RID: 150222
		[Token(Token = "0x4024ACE")]
		[FieldOffset(Offset = "0xC0")]
		private SoCharMissionRightPart.Adapter m_adatper;

		// Token: 0x04024ACF RID: 150223
		[Token(Token = "0x4024ACF")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_expInited;

		// Token: 0x04024AD0 RID: 150224
		[Token(Token = "0x4024AD0")]
		[FieldOffset(Offset = "0xCC")]
		private int m_cacheExp;

		// Token: 0x04024AD1 RID: 150225
		[Token(Token = "0x4024AD1")]
		[FieldOffset(Offset = "0xD0")]
		private int m_cacheLvl;

		// Token: 0x04024AD2 RID: 150226
		[Token(Token = "0x4024AD2")]
		[FieldOffset(Offset = "0xD8")]
		private Tween m_expTween;

		// Token: 0x04024AD3 RID: 150227
		[Token(Token = "0x4024AD3")]
		[FieldOffset(Offset = "0xE0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04024AD4 RID: 150228
		[Token(Token = "0x4024AD4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitAdapterIfNot;

		// Token: 0x04024AD5 RID: 150229
		[Token(Token = "0x4024AD5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetPos;

		// Token: 0x04024AD6 RID: 150230
		[Token(Token = "0x4024AD6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderNoPart;

		// Token: 0x04024AD7 RID: 150231
		[Token(Token = "0x4024AD7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderMission;

		// Token: 0x04024AD8 RID: 150232
		[Token(Token = "0x4024AD8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderExp;

		// Token: 0x04024AD9 RID: 150233
		[Token(Token = "0x4024AD9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RenderChar;

		// Token: 0x04024ADA RID: 150234
		[Token(Token = "0x4024ADA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020048AE RID: 18606
		[Token(Token = "0x20048AE")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170042A5 RID: 17061
			// (get) Token: 0x0601C130 RID: 114992 RVA: 0x000A7238 File Offset: 0x000A5438
			[Token(Token = "0x170042A5")]
			public override int count
			{
				[Token(Token = "0x601C130")]
				[Address(RVA = "0x15625F0", Offset = "0x15611F0", VA = "0x1815625F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601C131 RID: 114993 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C131")]
			[Address(RVA = "0x1562400", Offset = "0x1561000", VA = "0x181562400", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601C132 RID: 114994 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C132")]
			[Address(RVA = "0x1562590", Offset = "0x1561190", VA = "0x181562590")]
			public Adapter()
			{
			}

			// Token: 0x04024ADB RID: 150235
			[Token(Token = "0x4024ADB")]
			[FieldOffset(Offset = "0x20")]
			public Vector3 expPos;

			// Token: 0x04024ADC RID: 150236
			[Token(Token = "0x4024ADC")]
			[FieldOffset(Offset = "0x30")]
			public List<MissionViewModel> missionModelList;

			// Token: 0x04024ADD RID: 150237
			[Token(Token = "0x4024ADD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04024ADE RID: 150238
			[Token(Token = "0x4024ADE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04024ADF RID: 150239
			[Token(Token = "0x4024ADF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
