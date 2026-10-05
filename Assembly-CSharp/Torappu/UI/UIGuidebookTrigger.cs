using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003711 RID: 14097
	[Token(Token = "0x2003711")]
	public class UIGuidebookTrigger : MonoBehaviour, UIGuidebookController.IGuidebookListener
	{
		// Token: 0x06016602 RID: 91650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016602")]
		[Address(RVA = "0xED13C0", Offset = "0xECFFC0", VA = "0x180ED13C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06016603 RID: 91651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016603")]
		[Address(RVA = "0xED1220", Offset = "0xECFE20", VA = "0x180ED1220")]
		public void Start()
		{
		}

		// Token: 0x06016604 RID: 91652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016604")]
		[Address(RVA = "0xECF470", Offset = "0xECE070", VA = "0x180ECF470")]
		public void OnDestroy()
		{
		}

		// Token: 0x06016605 RID: 91653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016605")]
		[Address(RVA = "0xED10E0", Offset = "0xECFCE0", VA = "0x180ED10E0")]
		public void OnClicked()
		{
		}

		// Token: 0x06016606 RID: 91654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016606")]
		[Address(RVA = "0xED10E0", Offset = "0xECFCE0", VA = "0x180ED10E0")]
		public void ManualTrigger()
		{
		}

		// Token: 0x06016607 RID: 91655 RVA: 0x00090D50 File Offset: 0x0008EF50
		[Token(Token = "0x6016607")]
		[Address(RVA = "0xED1130", Offset = "0xECFD30", VA = "0x180ED1130", Slot = "4")]
		public bool OnAutoShow(UIGuideTarget target, string subsignal)
		{
			return default(bool);
		}

		// Token: 0x06016608 RID: 91656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016608")]
		[Address(RVA = "0xED1540", Offset = "0xED0140", VA = "0x180ED1540")]
		private void _OnGuidebookClosed()
		{
		}

		// Token: 0x06016609 RID: 91657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016609")]
		[Address(RVA = "0xED1410", Offset = "0xED0010", VA = "0x180ED1410")]
		private void _OnGuideBookOpen()
		{
		}

		// Token: 0x0601660A RID: 91658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601660A")]
		[Address(RVA = "0xED10E0", Offset = "0xECFCE0", VA = "0x180ED10E0")]
		private void _DoTriggerImpl()
		{
		}

		// Token: 0x0601660B RID: 91659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601660B")]
		[Address(RVA = "0xED15F0", Offset = "0xED01F0", VA = "0x180ED15F0")]
		private void _OpenGuidebook()
		{
		}

		// Token: 0x0601660C RID: 91660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601660C")]
		[Address(RVA = "0xED1370", Offset = "0xECFF70", VA = "0x180ED1370")]
		private void _ClearPageBlocker()
		{
		}

		// Token: 0x0601660D RID: 91661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601660D")]
		[Address(RVA = "0xED1780", Offset = "0xED0380", VA = "0x180ED1780")]
		public UIGuidebookTrigger()
		{
		}

		// Token: 0x0401AEAB RID: 110251
		[Token(Token = "0x401AEAB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string[] _pageIds;

		// Token: 0x0401AEAC RID: 110252
		[Token(Token = "0x401AEAC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Target to trigger auto show, NONE for always don't auto show")]
		private UIGuideTarget _autoShowTarget;

		// Token: 0x0401AEAD RID: 110253
		[Token(Token = "0x401AEAD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Extra signal used to check if targe matches (ignore case)")]
		private string _subsignal;

		// Token: 0x0401AEAE RID: 110254
		[Token(Token = "0x401AEAE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("Allow the trigger to use a dynamic config")]
		private string _dynConfig;

		// Token: 0x0401AEAF RID: 110255
		[Token(Token = "0x401AEAF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Tooltip("Load guidebook config from db")]
		private string _guidebookGroupId;

		// Token: 0x0401AEB0 RID: 110256
		[Token(Token = "0x401AEB0")]
		[FieldOffset(Offset = "0x40")]
		private UIGuidebookTrigger.Config m_config;

		// Token: 0x0401AEB1 RID: 110257
		[Token(Token = "0x401AEB1")]
		[FieldOffset(Offset = "0x58")]
		private RefCountReference m_pageBlockRef;

		// Token: 0x0401AEB2 RID: 110258
		[Token(Token = "0x401AEB2")]
		[FieldOffset(Offset = "0x60")]
		private UIPage.UIBlockHandler m_pageBlocker;

		// Token: 0x0401AEB3 RID: 110259
		[Token(Token = "0x401AEB3")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x02003712 RID: 14098
		[Token(Token = "0x2003712")]
		private struct Config
		{
			// Token: 0x0601660E RID: 91662 RVA: 0x00090D68 File Offset: 0x0008EF68
			[Token(Token = "0x601660E")]
			[Address(RVA = "0xEC1C50", Offset = "0xEC0850", VA = "0x180EC1C50")]
			public static UIGuidebookTrigger.Config CreateInst(UIGuidebookTrigger trigger)
			{
				return default(UIGuidebookTrigger.Config);
			}

			// Token: 0x0601660F RID: 91663 RVA: 0x00090D80 File Offset: 0x0008EF80
			[Token(Token = "0x601660F")]
			[Address(RVA = "0xEC1F00", Offset = "0xEC0B00", VA = "0x180EC1F00")]
			private static bool _CreateInstByDynConfigId(string dynConfigId, out UIGuidebookTrigger.Config config)
			{
				return default(bool);
			}

			// Token: 0x06016610 RID: 91664 RVA: 0x00090D98 File Offset: 0x0008EF98
			[Token(Token = "0x6016610")]
			[Address(RVA = "0xEC2070", Offset = "0xEC0C70", VA = "0x180EC2070")]
			private static bool _CreateInstByGroupId(string guidebookGroupId, out UIGuidebookTrigger.Config config)
			{
				return default(bool);
			}

			// Token: 0x06016611 RID: 91665 RVA: 0x00090DB0 File Offset: 0x0008EFB0
			[Token(Token = "0x6016611")]
			[Address(RVA = "0xEC1E40", Offset = "0xEC0A40", VA = "0x180EC1E40")]
			public bool IsTargetMatch(UIGuideTarget iTarget, string iSubsignal)
			{
				return default(bool);
			}

			// Token: 0x0401AEB4 RID: 110260
			[Token(Token = "0x401AEB4")]
			[FieldOffset(Offset = "0x0")]
			public string[] pageIds;

			// Token: 0x0401AEB5 RID: 110261
			[Token(Token = "0x401AEB5")]
			[FieldOffset(Offset = "0x8")]
			public UIGuideTarget autoShowTarget;

			// Token: 0x0401AEB6 RID: 110262
			[Token(Token = "0x401AEB6")]
			[FieldOffset(Offset = "0x10")]
			public string subsignal;
		}
	}
}
