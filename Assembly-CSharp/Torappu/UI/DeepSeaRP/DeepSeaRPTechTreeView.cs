using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005184 RID: 20868
	[Token(Token = "0x2005184")]
	public class DeepSeaRPTechTreeView : DataBinder<DeepSeaRPTechTreeViewProperty>
	{
		// Token: 0x170047D7 RID: 18391
		// (get) Token: 0x0601ED6B RID: 126315 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601ED6C RID: 126316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170047D7")]
		public Action<string> onTechSetClicked
		{
			[Token(Token = "0x601ED6B")]
			[Address(RVA = "0x189E120", Offset = "0x189CD20", VA = "0x18189E120")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601ED6C")]
			[Address(RVA = "0x189E360", Offset = "0x189CF60", VA = "0x18189E360")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170047D8 RID: 18392
		// (get) Token: 0x0601ED6D RID: 126317 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601ED6E RID: 126318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170047D8")]
		public Action<string> onTechUnSetClicked
		{
			[Token(Token = "0x601ED6D")]
			[Address(RVA = "0x189E180", Offset = "0x189CD80", VA = "0x18189E180")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601ED6E")]
			[Address(RVA = "0x189E3E0", Offset = "0x189CFE0", VA = "0x18189E3E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170047D9 RID: 18393
		// (get) Token: 0x0601ED6F RID: 126319 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601ED70 RID: 126320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170047D9")]
		public Action<string> onTechActiveClicked
		{
			[Token(Token = "0x601ED6F")]
			[Address(RVA = "0x189E060", Offset = "0x189CC60", VA = "0x18189E060")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601ED70")]
			[Address(RVA = "0x189E260", Offset = "0x189CE60", VA = "0x18189E260")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170047DA RID: 18394
		// (get) Token: 0x0601ED71 RID: 126321 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601ED72 RID: 126322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170047DA")]
		public Action<string> onTechNodeToggleClicked
		{
			[Token(Token = "0x601ED71")]
			[Address(RVA = "0x189E0C0", Offset = "0x189CCC0", VA = "0x18189E0C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601ED72")]
			[Address(RVA = "0x189E2E0", Offset = "0x189CEE0", VA = "0x18189E2E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170047DB RID: 18395
		// (get) Token: 0x0601ED73 RID: 126323 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601ED74 RID: 126324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170047DB")]
		public Action onSaveClicked
		{
			[Token(Token = "0x601ED73")]
			[Address(RVA = "0x189E000", Offset = "0x189CC00", VA = "0x18189E000")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601ED74")]
			[Address(RVA = "0x189E1E0", Offset = "0x189CDE0", VA = "0x18189E1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601ED75 RID: 126325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED75")]
		[Address(RVA = "0x189D510", Offset = "0x189C110", VA = "0x18189D510", Slot = "7")]
		public override void OnValueChanged(DeepSeaRPTechTreeViewProperty property)
		{
		}

		// Token: 0x0601ED76 RID: 126326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED76")]
		[Address(RVA = "0x189D990", Offset = "0x189C590", VA = "0x18189D990")]
		public void PlayEnterAnim()
		{
		}

		// Token: 0x0601ED77 RID: 126327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED77")]
		[Address(RVA = "0x189DEB0", Offset = "0x189CAB0", VA = "0x18189DEB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601ED78 RID: 126328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED78")]
		[Address(RVA = "0x189DA30", Offset = "0x189C630", VA = "0x18189DA30")]
		private void _EventOnActiveClick(string techId)
		{
		}

		// Token: 0x0601ED79 RID: 126329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED79")]
		[Address(RVA = "0x189DC70", Offset = "0x189C870", VA = "0x18189DC70")]
		private void _EventOnSetClick(string techId)
		{
		}

		// Token: 0x0601ED7A RID: 126330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED7A")]
		[Address(RVA = "0x189DD90", Offset = "0x189C990", VA = "0x18189DD90")]
		private void _EventOnUnsetClick(string techId)
		{
		}

		// Token: 0x0601ED7B RID: 126331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED7B")]
		[Address(RVA = "0x189DB50", Offset = "0x189C750", VA = "0x18189DB50")]
		private void _EventOnNodeToggleClick(string techId)
		{
		}

		// Token: 0x0601ED7C RID: 126332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED7C")]
		[Address(RVA = "0x189D400", Offset = "0x189C000", VA = "0x18189D400")]
		public void EventOnSaveClick()
		{
		}

		// Token: 0x0601ED7D RID: 126333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED7D")]
		[Address(RVA = "0x189DF90", Offset = "0x189CB90", VA = "0x18189DF90")]
		public DeepSeaRPTechTreeView()
		{
		}

		// Token: 0x040295C8 RID: 169416
		[Token(Token = "0x40295C8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<DeepSeaRPTechTreeNodeView> _nodeList;

		// Token: 0x040295C9 RID: 169417
		[Token(Token = "0x40295C9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objSavePart;

		// Token: 0x040295CA RID: 169418
		[Token(Token = "0x40295CA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasSavedPart;

		// Token: 0x040295CB RID: 169419
		[Token(Token = "0x40295CB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x040295CC RID: 169420
		[Token(Token = "0x40295CC")]
		[FieldOffset(Offset = "0x48")]
		private DeepSeaRPTechTreeViewModel m_viewModel;

		// Token: 0x040295CD RID: 169421
		[Token(Token = "0x40295CD")]
		[FieldOffset(Offset = "0x50")]
		private bool m_inited;

		// Token: 0x040295CE RID: 169422
		[Token(Token = "0x40295CE")]
		[FieldOffset(Offset = "0x58")]
		private FadeSwitchTween m_tweenSaved;

		// Token: 0x040295CF RID: 169423
		[Token(Token = "0x40295CF")]
		private const float DUR_SAVED_FADE_OUT = 0.2f;

		// Token: 0x040295D5 RID: 169429
		[Token(Token = "0x40295D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onTechSetClicked;

		// Token: 0x040295D6 RID: 169430
		[Token(Token = "0x40295D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onTechSetClicked;

		// Token: 0x040295D7 RID: 169431
		[Token(Token = "0x40295D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onTechUnSetClicked;

		// Token: 0x040295D8 RID: 169432
		[Token(Token = "0x40295D8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onTechUnSetClicked;

		// Token: 0x040295D9 RID: 169433
		[Token(Token = "0x40295D9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onTechActiveClicked;

		// Token: 0x040295DA RID: 169434
		[Token(Token = "0x40295DA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onTechActiveClicked;

		// Token: 0x040295DB RID: 169435
		[Token(Token = "0x40295DB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_onTechNodeToggleClicked;

		// Token: 0x040295DC RID: 169436
		[Token(Token = "0x40295DC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_onTechNodeToggleClicked;

		// Token: 0x040295DD RID: 169437
		[Token(Token = "0x40295DD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_onSaveClicked;

		// Token: 0x040295DE RID: 169438
		[Token(Token = "0x40295DE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_onSaveClicked;

		// Token: 0x040295DF RID: 169439
		[Token(Token = "0x40295DF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040295E0 RID: 169440
		[Token(Token = "0x40295E0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_PlayEnterAnim;

		// Token: 0x040295E1 RID: 169441
		[Token(Token = "0x40295E1")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040295E2 RID: 169442
		[Token(Token = "0x40295E2")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__EventOnActiveClick;

		// Token: 0x040295E3 RID: 169443
		[Token(Token = "0x40295E3")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__EventOnSetClick;

		// Token: 0x040295E4 RID: 169444
		[Token(Token = "0x40295E4")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__EventOnUnsetClick;

		// Token: 0x040295E5 RID: 169445
		[Token(Token = "0x40295E5")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__EventOnNodeToggleClick;

		// Token: 0x040295E6 RID: 169446
		[Token(Token = "0x40295E6")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EventOnSaveClick;

		// Token: 0x040295E7 RID: 169447
		[Token(Token = "0x40295E7")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
