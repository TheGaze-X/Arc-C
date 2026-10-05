using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.CharacterInfo;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C53 RID: 15443
	[Token(Token = "0x2003C53")]
	public class UniEquipUnlockView : DataBinder<UnlockViewProperty>
	{
		// Token: 0x0601822B RID: 98859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601822B")]
		[Address(RVA = "0x10A25A0", Offset = "0x10A11A0", VA = "0x1810A25A0", Slot = "7")]
		public override void OnValueChanged(UnlockViewProperty property)
		{
		}

		// Token: 0x0601822C RID: 98860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601822C")]
		[Address(RVA = "0x10A2B80", Offset = "0x10A1780", VA = "0x1810A2B80")]
		public void ResetAnim()
		{
		}

		// Token: 0x0601822D RID: 98861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601822D")]
		[Address(RVA = "0x10A2A00", Offset = "0x10A1600", VA = "0x1810A2A00")]
		public void PlayEnterAnim()
		{
		}

		// Token: 0x0601822E RID: 98862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601822E")]
		[Address(RVA = "0x10A2AD0", Offset = "0x10A16D0", VA = "0x1810A2AD0")]
		public void PlayTransPreviewAnim(bool isShow)
		{
		}

		// Token: 0x0601822F RID: 98863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601822F")]
		[Address(RVA = "0x10A2F90", Offset = "0x10A1B90", VA = "0x1810A2F90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018230 RID: 98864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018230")]
		[Address(RVA = "0x10A2DB0", Offset = "0x10A19B0", VA = "0x1810A2DB0")]
		private void _AnimInitIfNot()
		{
		}

		// Token: 0x06018231 RID: 98865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018231")]
		[Address(RVA = "0x10A30D0", Offset = "0x10A1CD0", VA = "0x1810A30D0")]
		private void _ResetInfoAnim(bool isShow)
		{
		}

		// Token: 0x06018232 RID: 98866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018232")]
		[Address(RVA = "0x10A2ED0", Offset = "0x10A1AD0", VA = "0x1810A2ED0")]
		private IEnumerator _InfoEffectAnim(bool isShow)
		{
			return null;
		}

		// Token: 0x06018233 RID: 98867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018233")]
		[Address(RVA = "0x10A3270", Offset = "0x10A1E70", VA = "0x1810A3270")]
		public UniEquipUnlockView()
		{
		}

		// Token: 0x0401D570 RID: 120176
		[Token(Token = "0x401D570")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _equipImg;

		// Token: 0x0401D571 RID: 120177
		[Token(Token = "0x401D571")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelMission;

		// Token: 0x0401D572 RID: 120178
		[Token(Token = "0x401D572")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UniEquipUnlockMissionItemView _missionPrefab;

		// Token: 0x0401D573 RID: 120179
		[Token(Token = "0x401D573")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _mission1Container;

		// Token: 0x0401D574 RID: 120180
		[Token(Token = "0x401D574")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _mission2Container;

		// Token: 0x0401D575 RID: 120181
		[Token(Token = "0x401D575")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _infoLayoutContent;

		// Token: 0x0401D576 RID: 120182
		[Token(Token = "0x401D576")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _itemLayoutContent;

		// Token: 0x0401D577 RID: 120183
		[Token(Token = "0x401D577")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _confirmInfoText;

		// Token: 0x0401D578 RID: 120184
		[Token(Token = "0x401D578")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AnimationWrapper _equipAnimationWrapper;

		// Token: 0x0401D579 RID: 120185
		[Token(Token = "0x401D579")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAnimationLocation _previewLocation;

		// Token: 0x0401D57A RID: 120186
		[Token(Token = "0x401D57A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CharacterInfoSpOpView _spOpView;

		// Token: 0x0401D57B RID: 120187
		[Token(Token = "0x401D57B")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0401D57C RID: 120188
		[Token(Token = "0x401D57C")]
		[FieldOffset(Offset = "0x81")]
		private bool m_isAnimInited;

		// Token: 0x0401D57D RID: 120189
		[Token(Token = "0x401D57D")]
		[FieldOffset(Offset = "0x88")]
		private string ANIM_PARAM;

		// Token: 0x0401D57E RID: 120190
		[Token(Token = "0x401D57E")]
		[FieldOffset(Offset = "0x90")]
		private UniEquipUnlockView.InfoAdapter m_infoAdapter;

		// Token: 0x0401D57F RID: 120191
		[Token(Token = "0x401D57F")]
		[FieldOffset(Offset = "0x98")]
		private UniEquipUnlockView.ItemAdapter m_itemAdapter;

		// Token: 0x0401D580 RID: 120192
		[Token(Token = "0x401D580")]
		[FieldOffset(Offset = "0xA0")]
		private UniEquipUnlockMissionItemView m_mission1View;

		// Token: 0x0401D581 RID: 120193
		[Token(Token = "0x401D581")]
		[FieldOffset(Offset = "0xA8")]
		private UniEquipUnlockMissionItemView m_mission2View;

		// Token: 0x0401D582 RID: 120194
		[Token(Token = "0x401D582")]
		[FieldOffset(Offset = "0xB0")]
		private AnimationSwitchTween m_animTransPreviewSwitchTween;

		// Token: 0x0401D583 RID: 120195
		[Token(Token = "0x401D583")]
		[FieldOffset(Offset = "0xB8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401D584 RID: 120196
		[Token(Token = "0x401D584")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401D585 RID: 120197
		[Token(Token = "0x401D585")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ResetAnim;

		// Token: 0x0401D586 RID: 120198
		[Token(Token = "0x401D586")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PlayEnterAnim;

		// Token: 0x0401D587 RID: 120199
		[Token(Token = "0x401D587")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PlayTransPreviewAnim;

		// Token: 0x0401D588 RID: 120200
		[Token(Token = "0x401D588")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D589 RID: 120201
		[Token(Token = "0x401D589")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__AnimInitIfNot;

		// Token: 0x0401D58A RID: 120202
		[Token(Token = "0x401D58A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ResetInfoAnim;

		// Token: 0x0401D58B RID: 120203
		[Token(Token = "0x401D58B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InfoEffectAnim;

		// Token: 0x0401D58C RID: 120204
		[Token(Token = "0x401D58C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C54 RID: 15444
		[Token(Token = "0x2003C54")]
		private class InfoAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170039A9 RID: 14761
			// (get) Token: 0x06018234 RID: 98868 RVA: 0x000997E0 File Offset: 0x000979E0
			[Token(Token = "0x170039A9")]
			public override int count
			{
				[Token(Token = "0x6018234")]
				[Address(RVA = "0x108E4D0", Offset = "0x108D0D0", VA = "0x18108E4D0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018235 RID: 98869 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018235")]
			[Address(RVA = "0x108E260", Offset = "0x108CE60", VA = "0x18108E260", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06018236 RID: 98870 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018236")]
			[Address(RVA = "0x108E410", Offset = "0x108D010", VA = "0x18108E410")]
			public InfoAdapter()
			{
			}

			// Token: 0x0401D58D RID: 120205
			[Token(Token = "0x401D58D")]
			[FieldOffset(Offset = "0x20")]
			public UniEquipUnlockViewModel viewModel;

			// Token: 0x0401D58E RID: 120206
			[Token(Token = "0x401D58E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401D58F RID: 120207
			[Token(Token = "0x401D58F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0401D590 RID: 120208
			[Token(Token = "0x401D590")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003C55 RID: 15445
		[Token(Token = "0x2003C55")]
		private class ItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170039AA RID: 14762
			// (get) Token: 0x06018237 RID: 98871 RVA: 0x000997F8 File Offset: 0x000979F8
			[Token(Token = "0x170039AA")]
			public override int count
			{
				[Token(Token = "0x6018237")]
				[Address(RVA = "0x108EB60", Offset = "0x108D760", VA = "0x18108EB60", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018238 RID: 98872 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018238")]
			[Address(RVA = "0x108E8A0", Offset = "0x108D4A0", VA = "0x18108E8A0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06018239 RID: 98873 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018239")]
			[Address(RVA = "0x108EB00", Offset = "0x108D700", VA = "0x18108EB00")]
			public ItemAdapter()
			{
			}

			// Token: 0x0401D591 RID: 120209
			[Token(Token = "0x401D591")]
			[FieldOffset(Offset = "0x20")]
			public UniEquipUnlockViewModel viewModel;

			// Token: 0x0401D592 RID: 120210
			[Token(Token = "0x401D592")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401D593 RID: 120211
			[Token(Token = "0x401D593")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0401D594 RID: 120212
			[Token(Token = "0x401D594")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
