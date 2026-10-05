using System;
using System.Collections;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace HGSDK.UI
{
	// Token: 0x020001C9 RID: 457
	[Token(Token = "0x20001C9")]
	public class UIManager
	{
		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x00003D08 File Offset: 0x00001F08
		[Token(Token = "0x17000111")]
		[Inspect(InspectorLevel.Debug)]
		public bool isShownUI
		{
			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x25389B0", Offset = "0x25375B0", VA = "0x1825389B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000112")]
		public HGSDK sdk
		{
			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x25388B0", Offset = "0x25374B0", VA = "0x1825388B0")]
		public UIManager(HGSDK sdk, UIManager.Options options)
		{
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x2538650", Offset = "0x2537250", VA = "0x182538650")]
		public void OnStart()
		{
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DE")]
		public PageType OpenUIPage<PageType>(PageType uiPrefab, Action<PageType> onLoaded) where PageType : HGSDK.UIPage
		{
			return null;
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00003D20 File Offset: 0x00001F20
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x2538540", Offset = "0x2537140", VA = "0x182538540")]
		public bool CloseUIPage(HGSDK.UIPage ui)
		{
			return default(bool);
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00003D38 File Offset: 0x00001F38
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x25384A0", Offset = "0x25370A0", VA = "0x1825384A0")]
		public bool CloseCurrentUIPage()
		{
			return default(bool);
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00003D50 File Offset: 0x00001F50
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x2538410", Offset = "0x2537010", VA = "0x182538410")]
		public bool BlockRaycast(bool isBlock, UIManager.RaycastBlockerSource source)
		{
			return default(bool);
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x25386E0", Offset = "0x25372E0", VA = "0x1825386E0")]
		private IEnumerator _DoOpenUICoroutine()
		{
			return null;
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x2538660", Offset = "0x2537260", VA = "0x182538660")]
		private IEnumerator _DoCloseUICoroutine()
		{
			return null;
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x2538760", Offset = "0x2537360", VA = "0x182538760")]
		private void _UpdateViews()
		{
		}

		// Token: 0x04000A25 RID: 2597
		[Token(Token = "0x4000A25")]
		[FieldOffset(Offset = "0x10")]
		private UIManager.Options m_options;

		// Token: 0x04000A26 RID: 2598
		[Token(Token = "0x4000A26")]
		[FieldOffset(Offset = "0x30")]
		private HGSDK.UIPage m_currentPage;

		// Token: 0x04000A27 RID: 2599
		[Token(Token = "0x4000A27")]
		[FieldOffset(Offset = "0x38")]
		private UIManager.RaycastBlockerMgr m_raycastBlockerMgr;

		// Token: 0x020001CA RID: 458
		[Token(Token = "0x20001CA")]
		public enum RaycastBlockerSource
		{
			// Token: 0x04000A2A RID: 2602
			[Token(Token = "0x4000A2A")]
			MANAGER,
			// Token: 0x04000A2B RID: 2603
			[Token(Token = "0x4000A2B")]
			PAGE,
			// Token: 0x04000A2C RID: 2604
			[Token(Token = "0x4000A2C")]
			E_NUM
		}

		// Token: 0x020001CB RID: 459
		[Token(Token = "0x20001CB")]
		[Serializable]
		public struct Options
		{
			// Token: 0x04000A2D RID: 2605
			[Token(Token = "0x4000A2D")]
			[FieldOffset(Offset = "0x0")]
			public Camera camera;

			// Token: 0x04000A2E RID: 2606
			[Token(Token = "0x4000A2E")]
			[FieldOffset(Offset = "0x8")]
			public Canvas uiRoot;

			// Token: 0x04000A2F RID: 2607
			[Token(Token = "0x4000A2F")]
			[FieldOffset(Offset = "0x10")]
			public RectTransform pageRoot;

			// Token: 0x04000A30 RID: 2608
			[Token(Token = "0x4000A30")]
			[FieldOffset(Offset = "0x18")]
			public RectTransform blockMask;
		}

		// Token: 0x020001CC RID: 460
		[Token(Token = "0x20001CC")]
		private class RaycastBlockerMgr
		{
			// Token: 0x17000113 RID: 275
			// (get) Token: 0x060007E5 RID: 2021 RVA: 0x00003D68 File Offset: 0x00001F68
			// (set) Token: 0x060007E6 RID: 2022 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000113")]
			public bool isTurnedOff
			{
				[Token(Token = "0x60007E5")]
				[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60007E6")]
				[Address(RVA = "0x4F1E30", Offset = "0x4F0A30", VA = "0x1804F1E30")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060007E7 RID: 2023 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x2534E70", Offset = "0x2533A70", VA = "0x182534E70")]
			public RaycastBlockerMgr(RectTransform blockMask)
			{
			}

			// Token: 0x060007E8 RID: 2024 RVA: 0x00003D80 File Offset: 0x00001F80
			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x2534D70", Offset = "0x2533970", VA = "0x182534D70")]
			public bool BlockRaycast(bool isBlock, UIManager.RaycastBlockerSource source)
			{
				return default(bool);
			}

			// Token: 0x060007E9 RID: 2025 RVA: 0x00003D98 File Offset: 0x00001F98
			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x2534E00", Offset = "0x2533A00", VA = "0x182534E00")]
			private bool _UpdateBlockStatus()
			{
				return default(bool);
			}

			// Token: 0x04000A31 RID: 2609
			[Token(Token = "0x4000A31")]
			private const int SOURCE_TYPE_NUM = 2;

			// Token: 0x04000A32 RID: 2610
			[Token(Token = "0x4000A32")]
			[FieldOffset(Offset = "0x10")]
			private RectTransform m_blockMask;

			// Token: 0x04000A33 RID: 2611
			[Token(Token = "0x4000A33")]
			[FieldOffset(Offset = "0x18")]
			private bool[] m_sourceChannels;
		}
	}
}
