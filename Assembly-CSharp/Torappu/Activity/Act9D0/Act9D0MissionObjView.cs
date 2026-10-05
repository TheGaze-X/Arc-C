using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Mission;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x0200716F RID: 29039
	[Token(Token = "0x200716F")]
	public class Act9D0MissionObjView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006197 RID: 24983
		// (get) Token: 0x0602939A RID: 168858 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602939B RID: 168859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006197")]
		public UIStringEvent onClicked
		{
			[Token(Token = "0x602939A")]
			[Address(RVA = "0x2499DF0", Offset = "0x24989F0", VA = "0x182499DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602939B")]
			[Address(RVA = "0x2499E50", Offset = "0x2498A50", VA = "0x182499E50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602939C RID: 168860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602939C")]
		[Address(RVA = "0x24985B0", Offset = "0x24971B0", VA = "0x1824985B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0602939D RID: 168861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602939D")]
		[Address(RVA = "0x24986D0", Offset = "0x24972D0", VA = "0x1824986D0")]
		public void Render(MissionViewModel model)
		{
		}

		// Token: 0x0602939E RID: 168862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602939E")]
		[Address(RVA = "0x2499550", Offset = "0x2498150", VA = "0x182499550")]
		private void _RenderItemList(MissionViewModel model)
		{
		}

		// Token: 0x0602939F RID: 168863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602939F")]
		[Address(RVA = "0x2498490", Offset = "0x2497090", VA = "0x182498490")]
		public void EventOnClicked()
		{
		}

		// Token: 0x060293A0 RID: 168864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293A0")]
		[Address(RVA = "0x2498DD0", Offset = "0x24979D0", VA = "0x182498DD0")]
		private void _EventOnItemClicked(int index)
		{
		}

		// Token: 0x060293A1 RID: 168865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293A1")]
		[Address(RVA = "0x2498EB0", Offset = "0x2497AB0", VA = "0x182498EB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060293A2 RID: 168866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293A2")]
		[Address(RVA = "0x2499CB0", Offset = "0x24988B0", VA = "0x182499CB0")]
		public Act9D0MissionObjView()
		{
		}

		// Token: 0x0403ADDB RID: 241115
		[Token(Token = "0x403ADDB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x0403ADDC RID: 241116
		[Token(Token = "0x403ADDC")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Color _textDescCompletedColor;

		// Token: 0x0403ADDD RID: 241117
		[Token(Token = "0x403ADDD")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Color _textDescInprogressColor;

		// Token: 0x0403ADDE RID: 241118
		[Token(Token = "0x403ADDE")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Color _textProgressValueColor;

		// Token: 0x0403ADDF RID: 241119
		[Token(Token = "0x403ADDF")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Color _textProgressTargetColor;

		// Token: 0x0403ADE0 RID: 241120
		[Token(Token = "0x403ADE0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0403ADE1 RID: 241121
		[Token(Token = "0x403ADE1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textProgress;

		// Token: 0x0403ADE2 RID: 241122
		[Token(Token = "0x403ADE2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Slider _sliderProgress;

		// Token: 0x0403ADE3 RID: 241123
		[Token(Token = "0x403ADE3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelCompleted;

		// Token: 0x0403ADE4 RID: 241124
		[Token(Token = "0x403ADE4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelInprogress;

		// Token: 0x0403ADE5 RID: 241125
		[Token(Token = "0x403ADE5")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _imageOutline;

		// Token: 0x0403ADE6 RID: 241126
		[Token(Token = "0x403ADE6")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _imageRewardGot;

		// Token: 0x0403ADE7 RID: 241127
		[Token(Token = "0x403ADE7")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Button _buttonSelf;

		// Token: 0x0403ADE8 RID: 241128
		[Token(Token = "0x403ADE8")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private List<GameObject> _notHaveImgList;

		// Token: 0x0403ADE9 RID: 241129
		[Token(Token = "0x403ADE9")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Container")]
		private List<RectTransform> _itemContainerList;

		// Token: 0x0403ADEA RID: 241130
		[Token(Token = "0x403ADEA")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Container")]
		private List<RectTransform> _replicateContainerList;

		// Token: 0x0403ADEB RID: 241131
		[Token(Token = "0x403ADEB")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Container")]
		private List<GameObject> _replicateIconList;

		// Token: 0x0403ADEC RID: 241132
		[Token(Token = "0x403ADEC")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Container")]
		[Obsolete("Don't config this and tweens would be used instead.")]
		private List<AnimationWrapper> _replicateAnimationList;

		// Token: 0x0403ADED RID: 241133
		[Token(Token = "0x403ADED")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private bool _hideSlideProgressWhenAbleToGet;

		// Token: 0x0403ADEE RID: 241134
		[Token(Token = "0x403ADEE")]
		private const string SHINING_ANIM = "mission_shining";

		// Token: 0x0403ADEF RID: 241135
		[Token(Token = "0x403ADEF")]
		[FieldOffset(Offset = "0xD0")]
		private string m_missionId;

		// Token: 0x0403ADF0 RID: 241136
		[Token(Token = "0x403ADF0")]
		[FieldOffset(Offset = "0xD8")]
		private List<UIItemCard> m_itemCardList;

		// Token: 0x0403ADF1 RID: 241137
		[Token(Token = "0x403ADF1")]
		[FieldOffset(Offset = "0xE0")]
		private List<UIItemCard> m_replicateItemCardList;

		// Token: 0x0403ADF2 RID: 241138
		[Token(Token = "0x403ADF2")]
		[FieldOffset(Offset = "0xE8")]
		private List<Act9D0MissionObjView.Act9D0MissionReplicateTweenWrapper> m_tweens;

		// Token: 0x0403ADF3 RID: 241139
		[Token(Token = "0x403ADF3")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_useAnimationWrapper;

		// Token: 0x0403ADF4 RID: 241140
		[Token(Token = "0x403ADF4")]
		[FieldOffset(Offset = "0xF1")]
		private bool m_isInited;

		// Token: 0x0403ADF6 RID: 241142
		[Token(Token = "0x403ADF6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClicked;

		// Token: 0x0403ADF7 RID: 241143
		[Token(Token = "0x403ADF7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClicked;

		// Token: 0x0403ADF8 RID: 241144
		[Token(Token = "0x403ADF8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403ADF9 RID: 241145
		[Token(Token = "0x403ADF9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403ADFA RID: 241146
		[Token(Token = "0x403ADFA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderItemList;

		// Token: 0x0403ADFB RID: 241147
		[Token(Token = "0x403ADFB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0403ADFC RID: 241148
		[Token(Token = "0x403ADFC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EventOnItemClicked;

		// Token: 0x0403ADFD RID: 241149
		[Token(Token = "0x403ADFD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403ADFE RID: 241150
		[Token(Token = "0x403ADFE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007170 RID: 29040
		[Token(Token = "0x2007170")]
		private class Act9D0MissionReplicateTweenWrapper : IHotfixable, IDisposable
		{
			// Token: 0x060293A3 RID: 168867 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60293A3")]
			[Address(RVA = "0x249A010", Offset = "0x2498C10", VA = "0x18249A010")]
			public void SetCanvasGroup(CanvasGroup item, CanvasGroup replicate)
			{
			}

			// Token: 0x060293A4 RID: 168868 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60293A4")]
			[Address(RVA = "0x249A0B0", Offset = "0x2498CB0", VA = "0x18249A0B0")]
			public void SetTween()
			{
			}

			// Token: 0x060293A5 RID: 168869 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60293A5")]
			[Address(RVA = "0x2499F50", Offset = "0x2498B50", VA = "0x182499F50")]
			public void KillTween()
			{
			}

			// Token: 0x060293A6 RID: 168870 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60293A6")]
			[Address(RVA = "0x2499ED0", Offset = "0x2498AD0", VA = "0x182499ED0", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x060293A7 RID: 168871 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60293A7")]
			[Address(RVA = "0x249A570", Offset = "0x2499170", VA = "0x18249A570")]
			public Act9D0MissionReplicateTweenWrapper()
			{
			}

			// Token: 0x0403ADFF RID: 241151
			[Token(Token = "0x403ADFF")]
			private const float ANIMATION_ANIM_SPEED = 3f;

			// Token: 0x0403AE00 RID: 241152
			[Token(Token = "0x403AE00")]
			[FieldOffset(Offset = "0x10")]
			private CanvasGroup m_itemCanvasGroup;

			// Token: 0x0403AE01 RID: 241153
			[Token(Token = "0x403AE01")]
			[FieldOffset(Offset = "0x18")]
			private CanvasGroup m_replicateCanvasGroup;

			// Token: 0x0403AE02 RID: 241154
			[Token(Token = "0x403AE02")]
			[FieldOffset(Offset = "0x20")]
			private Sequence m_tween;

			// Token: 0x0403AE03 RID: 241155
			[Token(Token = "0x403AE03")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetCanvasGroup;

			// Token: 0x0403AE04 RID: 241156
			[Token(Token = "0x403AE04")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SetTween;

			// Token: 0x0403AE05 RID: 241157
			[Token(Token = "0x403AE05")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_KillTween;

			// Token: 0x0403AE06 RID: 241158
			[Token(Token = "0x403AE06")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Dispose;

			// Token: 0x0403AE07 RID: 241159
			[Token(Token = "0x403AE07")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
