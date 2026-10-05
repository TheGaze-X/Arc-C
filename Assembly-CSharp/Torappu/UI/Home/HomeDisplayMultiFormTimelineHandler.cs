using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B57 RID: 19287
	[Token(Token = "0x2004B57")]
	public class HomeDisplayMultiFormTimelineHandler : MonoBehaviour, IMultiFormHandler, IHotfixable
	{
		// Token: 0x0601D0A8 RID: 118952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0A8")]
		[Address(RVA = "0x1671F20", Offset = "0x1670B20", VA = "0x181671F20")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601D0A9 RID: 118953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0A9")]
		[Address(RVA = "0x1671F80", Offset = "0x1670B80", VA = "0x181671F80", Slot = "4")]
		public void OnMultiFormChanged(HomeDisplayMultiFormItemModel formModel, bool shouldReset)
		{
		}

		// Token: 0x0601D0AA RID: 118954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0AA")]
		[Address(RVA = "0x16720F0", Offset = "0x1670CF0", VA = "0x1816720F0")]
		public void SetBinding(string name, Animator animator)
		{
		}

		// Token: 0x0601D0AB RID: 118955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0AB")]
		[Address(RVA = "0x16721A0", Offset = "0x1670DA0", VA = "0x1816721A0")]
		public void StopAll()
		{
		}

		// Token: 0x0601D0AC RID: 118956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0AC")]
		[Address(RVA = "0x1672210", Offset = "0x1670E10", VA = "0x181672210")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D0AD RID: 118957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0AD")]
		[Address(RVA = "0x1672500", Offset = "0x1671100", VA = "0x181672500")]
		private void _Load(HomeDisplayMultiFormItemModel formModel)
		{
		}

		// Token: 0x0601D0AE RID: 118958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0AE")]
		[Address(RVA = "0x16722D0", Offset = "0x1670ED0", VA = "0x1816722D0")]
		private void _LoadTimelineAssets(HomeDisplayMultiFormItemModel formModel)
		{
		}

		// Token: 0x0601D0AF RID: 118959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0AF")]
		[Address(RVA = "0x16725C0", Offset = "0x16711C0", VA = "0x1816725C0")]
		private void _UnloadTimelineAssets(bool bClearBindTargets)
		{
		}

		// Token: 0x0601D0B0 RID: 118960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0B0")]
		[Address(RVA = "0x16727C0", Offset = "0x16713C0", VA = "0x1816727C0")]
		public HomeDisplayMultiFormTimelineHandler()
		{
		}

		// Token: 0x04026171 RID: 156017
		[Token(Token = "0x4026171")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PlayableDirector _director;

		// Token: 0x04026172 RID: 156018
		[Token(Token = "0x4026172")]
		[FieldOffset(Offset = "0x20")]
		private UITimelineRingClip m_timelineClip;

		// Token: 0x04026173 RID: 156019
		[Token(Token = "0x4026173")]
		[FieldOffset(Offset = "0x28")]
		private bool m_inited;

		// Token: 0x04026174 RID: 156020
		[Token(Token = "0x4026174")]
		[FieldOffset(Offset = "0x30")]
		private string m_cachedMainId;

		// Token: 0x04026175 RID: 156021
		[Token(Token = "0x4026175")]
		[FieldOffset(Offset = "0x38")]
		private TimelineAsset m_cachedForwardAsset;

		// Token: 0x04026176 RID: 156022
		[Token(Token = "0x4026176")]
		[FieldOffset(Offset = "0x40")]
		private TimelineAsset m_cachedBackwardAsset;

		// Token: 0x04026177 RID: 156023
		[Token(Token = "0x4026177")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04026178 RID: 156024
		[Token(Token = "0x4026178")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnMultiFormChanged;

		// Token: 0x04026179 RID: 156025
		[Token(Token = "0x4026179")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetBinding;

		// Token: 0x0402617A RID: 156026
		[Token(Token = "0x402617A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_StopAll;

		// Token: 0x0402617B RID: 156027
		[Token(Token = "0x402617B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402617C RID: 156028
		[Token(Token = "0x402617C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__Load;

		// Token: 0x0402617D RID: 156029
		[Token(Token = "0x402617D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadTimelineAssets;

		// Token: 0x0402617E RID: 156030
		[Token(Token = "0x402617E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UnloadTimelineAssets;

		// Token: 0x0402617F RID: 156031
		[Token(Token = "0x402617F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
