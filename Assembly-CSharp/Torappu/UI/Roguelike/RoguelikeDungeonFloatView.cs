using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200525C RID: 21084
	[Token(Token = "0x200525C")]
	public class RoguelikeDungeonFloatView : DataBinder<RoguelikeDungeonZoneViewProperty>
	{
		// Token: 0x0601F17D RID: 127357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F17D")]
		[Address(RVA = "0x18CB330", Offset = "0x18C9F30", VA = "0x1818CB330")]
		private void _RefreshGuideBookTrigger(PlayerRoguelikeZoneType zoneType)
		{
		}

		// Token: 0x0601F17E RID: 127358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F17E")]
		[Address(RVA = "0x18CAED0", Offset = "0x18C9AD0", VA = "0x1818CAED0")]
		private UIGuidebookTrigger _LoadGuideBookTrigger(string path)
		{
			return null;
		}

		// Token: 0x0601F17F RID: 127359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F17F")]
		[Address(RVA = "0x18CACB0", Offset = "0x18C98B0", VA = "0x1818CACB0", Slot = "7")]
		public override void OnValueChanged(RoguelikeDungeonZoneViewProperty property)
		{
		}

		// Token: 0x0601F180 RID: 127360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F180")]
		[Address(RVA = "0x18CB000", Offset = "0x18C9C00", VA = "0x1818CB000")]
		private void _OnStateEnter(object arg)
		{
		}

		// Token: 0x0601F181 RID: 127361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F181")]
		[Address(RVA = "0x18CB190", Offset = "0x18C9D90", VA = "0x1818CB190")]
		private void _OnStateResume(object arg)
		{
		}

		// Token: 0x0601F182 RID: 127362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F182")]
		[Address(RVA = "0x18CA9D0", Offset = "0x18C95D0", VA = "0x1818CA9D0")]
		public void Init(RoguelikeDungeonController controller)
		{
		}

		// Token: 0x0601F183 RID: 127363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F183")]
		[Address(RVA = "0x18CAD70", Offset = "0x18C9970", VA = "0x1818CAD70")]
		public void SetShow(bool isShow, bool fastMode)
		{
		}

		// Token: 0x0601F184 RID: 127364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F184")]
		[Address(RVA = "0x18CB700", Offset = "0x18CA300", VA = "0x1818CB700")]
		public RoguelikeDungeonFloatView()
		{
		}

		// Token: 0x04029B65 RID: 170853
		[Token(Token = "0x4029B65")]
		private const float TWEEN_DURATION = 0.5f;

		// Token: 0x04029B66 RID: 170854
		[Token(Token = "0x4029B66")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type[] ENABLE_STATES;

		// Token: 0x04029B67 RID: 170855
		[Token(Token = "0x4029B67")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type[] IGNORE_STATES;

		// Token: 0x04029B68 RID: 170856
		[Token(Token = "0x4029B68")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _triggerHolder;

		// Token: 0x04029B69 RID: 170857
		[Token(Token = "0x4029B69")]
		[FieldOffset(Offset = "0x28")]
		private UIGuidebookTrigger m_guideBookTrigger;

		// Token: 0x04029B6A RID: 170858
		[Token(Token = "0x4029B6A")]
		[FieldOffset(Offset = "0x30")]
		private FadeSwitchTween m_switchTween;

		// Token: 0x04029B6B RID: 170859
		[Token(Token = "0x4029B6B")]
		[FieldOffset(Offset = "0x38")]
		private RoguelikeDungeonZoneViewModel m_cacheZoneModel;

		// Token: 0x04029B6C RID: 170860
		[Token(Token = "0x4029B6C")]
		[FieldOffset(Offset = "0x40")]
		private PlayerRoguelikeZoneType m_cachedZoneType;

		// Token: 0x04029B6D RID: 170861
		[Token(Token = "0x4029B6D")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04029B6E RID: 170862
		[Token(Token = "0x4029B6E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RefreshGuideBookTrigger;

		// Token: 0x04029B6F RID: 170863
		[Token(Token = "0x4029B6F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadGuideBookTrigger;

		// Token: 0x04029B70 RID: 170864
		[Token(Token = "0x4029B70")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04029B71 RID: 170865
		[Token(Token = "0x4029B71")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnStateEnter;

		// Token: 0x04029B72 RID: 170866
		[Token(Token = "0x4029B72")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnStateResume;

		// Token: 0x04029B73 RID: 170867
		[Token(Token = "0x4029B73")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04029B74 RID: 170868
		[Token(Token = "0x4029B74")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetShow;

		// Token: 0x04029B75 RID: 170869
		[Token(Token = "0x4029B75")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
