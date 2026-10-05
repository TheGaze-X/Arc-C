using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BF4 RID: 15348
	[Token(Token = "0x2003BF4")]
	public class UniEquipArchiveModuleCollectionItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018021 RID: 98337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018021")]
		[Address(RVA = "0x1082700", Offset = "0x1081300", VA = "0x181082700")]
		public void Render(UniEquipArchiveModuleCollectionItemViewModel itemViewModel)
		{
		}

		// Token: 0x06018022 RID: 98338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018022")]
		[Address(RVA = "0x1083290", Offset = "0x1081E90", VA = "0x181083290")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018023 RID: 98339 RVA: 0x00098EE0 File Offset: 0x000970E0
		[Token(Token = "0x6018023")]
		[Address(RVA = "0x10831B0", Offset = "0x1081DB0", VA = "0x1810831B0")]
		private FadeSwitchTween.Builder _GetFadeBuilder(CanvasGroup canvasGroup)
		{
			return default(FadeSwitchTween.Builder);
		}

		// Token: 0x06018024 RID: 98340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018024")]
		[Address(RVA = "0x1082610", Offset = "0x1081210", VA = "0x181082610")]
		public void OnItemClick()
		{
		}

		// Token: 0x06018025 RID: 98341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018025")]
		[Address(RVA = "0x1082510", Offset = "0x1081110", VA = "0x181082510")]
		public void OnCharIconPartClick()
		{
		}

		// Token: 0x06018026 RID: 98342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018026")]
		[Address(RVA = "0x1083440", Offset = "0x1082040", VA = "0x181083440")]
		public UniEquipArchiveModuleCollectionItemView()
		{
		}

		// Token: 0x0401D175 RID: 119157
		[Token(Token = "0x401D175")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Base-Equip")]
		private Image _imgUniEquipIcon;

		// Token: 0x0401D176 RID: 119158
		[Token(Token = "0x401D176")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Base-Equip")]
		private Image _imgUniEquipTypeIcon;

		// Token: 0x0401D177 RID: 119159
		[Token(Token = "0x401D177")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Base-Equip")]
		private Text _txtUniEquipName;

		// Token: 0x0401D178 RID: 119160
		[Token(Token = "0x401D178")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Base-Equip")]
		private CanvasGroup _objEquipLvPart;

		// Token: 0x0401D179 RID: 119161
		[Token(Token = "0x401D179")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Base-Equip")]
		private UIAtlasObject _atlas;

		// Token: 0x0401D17A RID: 119162
		[Token(Token = "0x401D17A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Base-Equip")]
		private UIAtlasImage _imgUniEquipLevel;

		// Token: 0x0401D17B RID: 119163
		[Token(Token = "0x401D17B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Base-Equip")]
		private CanvasGroup _objEquipCanLvUpPart;

		// Token: 0x0401D17C RID: 119164
		[Token(Token = "0x401D17C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Base-Equip")]
		private CanvasGroup _objEquipLvMaxBgPart;

		// Token: 0x0401D17D RID: 119165
		[Token(Token = "0x401D17D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Base-Equip")]
		private GameObject _panelSingleType;

		// Token: 0x0401D17E RID: 119166
		[Token(Token = "0x401D17E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Base-Equip")]
		private GameObject _panelMultiType;

		// Token: 0x0401D17F RID: 119167
		[Token(Token = "0x401D17F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Base-Equip")]
		private Text _uniEquipSingleTypeDesc;

		// Token: 0x0401D180 RID: 119168
		[Token(Token = "0x401D180")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Base-Equip")]
		private Text _uniEquipMultiTypeDesc;

		// Token: 0x0401D181 RID: 119169
		[Token(Token = "0x401D181")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Base-Equip")]
		private Image _uniEquipMultiTypeDescImg;

		// Token: 0x0401D182 RID: 119170
		[Token(Token = "0x401D182")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Base-Equip")]
		private Image _imgShining;

		// Token: 0x0401D183 RID: 119171
		[Token(Token = "0x401D183")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Base-Char")]
		private Image _imgCharIcon;

		// Token: 0x0401D184 RID: 119172
		[Token(Token = "0x401D184")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Base-Char")]
		private Text _txtCharName;

		// Token: 0x0401D185 RID: 119173
		[Token(Token = "0x401D185")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Base-Char")]
		private GameObject _objCharPartClickBtn;

		// Token: 0x0401D186 RID: 119174
		[Token(Token = "0x401D186")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Mask")]
		private CanvasGroup _canvasNotPhase2Part;

		// Token: 0x0401D187 RID: 119175
		[Token(Token = "0x401D187")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Mask")]
		private CanvasGroup _canvasNotUnlockPart;

		// Token: 0x0401D188 RID: 119176
		[Token(Token = "0x401D188")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Mask")]
		private CanvasGroup _objNotUnlockMissionAll;

		// Token: 0x0401D189 RID: 119177
		[Token(Token = "0x401D189")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Mask")]
		private CanvasGroup _objNotUnlockMission1;

		// Token: 0x0401D18A RID: 119178
		[Token(Token = "0x401D18A")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Mask")]
		private CanvasGroup _objNotUnlockMission2;

		// Token: 0x0401D18B RID: 119179
		[Token(Token = "0x401D18B")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Mask")]
		private CanvasGroup _objNotUnlockMissionAllComplete;

		// Token: 0x0401D18C RID: 119180
		[Token(Token = "0x401D18C")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Mask")]
		private CanvasGroup _canvasCanUnlockPart;

		// Token: 0x0401D18D RID: 119181
		[Token(Token = "0x401D18D")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Mask")]
		private GameObject _objCanUnlockIconComplete;

		// Token: 0x0401D18E RID: 119182
		[Token(Token = "0x401D18E")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_hasInited;

		// Token: 0x0401D18F RID: 119183
		[Token(Token = "0x401D18F")]
		[FieldOffset(Offset = "0xE8")]
		private string m_cachedUniEquipId;

		// Token: 0x0401D190 RID: 119184
		[Token(Token = "0x401D190")]
		[FieldOffset(Offset = "0xF0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401D191 RID: 119185
		[Token(Token = "0x401D191")]
		[FieldOffset(Offset = "0x100")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401D192 RID: 119186
		[Token(Token = "0x401D192")]
		[FieldOffset(Offset = "0x110")]
		private FadeSwitchTween m_tweenNotPhase2;

		// Token: 0x0401D193 RID: 119187
		[Token(Token = "0x401D193")]
		[FieldOffset(Offset = "0x118")]
		private FadeSwitchTween m_tweenNotUnlock;

		// Token: 0x0401D194 RID: 119188
		[Token(Token = "0x401D194")]
		[FieldOffset(Offset = "0x120")]
		private FadeSwitchTween m_tweenCanUnlock;

		// Token: 0x0401D195 RID: 119189
		[Token(Token = "0x401D195")]
		[FieldOffset(Offset = "0x128")]
		private bool m_canCharCardPartClick;

		// Token: 0x0401D196 RID: 119190
		[Token(Token = "0x401D196")]
		private const string MODULE_LEVEL_PIC_PREFIX = "img_module_level_{0}";

		// Token: 0x0401D197 RID: 119191
		[Token(Token = "0x401D197")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D198 RID: 119192
		[Token(Token = "0x401D198")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D199 RID: 119193
		[Token(Token = "0x401D199")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetFadeBuilder;

		// Token: 0x0401D19A RID: 119194
		[Token(Token = "0x401D19A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x0401D19B RID: 119195
		[Token(Token = "0x401D19B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCharIconPartClick;

		// Token: 0x0401D19C RID: 119196
		[Token(Token = "0x401D19C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
