using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act38side
{
	// Token: 0x02007436 RID: 29750
	[Token(Token = "0x2007436")]
	public class Act38sideFireworkSquadPluginItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006319 RID: 25369
		// (get) Token: 0x06029FC1 RID: 171969 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06029FC2 RID: 171970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006319")]
		public Action<string> onItemClicked
		{
			[Token(Token = "0x6029FC1")]
			[Address(RVA = "0x25A67D0", Offset = "0x25A53D0", VA = "0x1825A67D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6029FC2")]
			[Address(RVA = "0x25A6830", Offset = "0x25A5430", VA = "0x1825A6830")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06029FC3 RID: 171971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FC3")]
		[Address(RVA = "0x25A6480", Offset = "0x25A5080", VA = "0x1825A6480")]
		public void EventOnItemClicked()
		{
		}

		// Token: 0x06029FC4 RID: 171972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FC4")]
		[Address(RVA = "0x25A6550", Offset = "0x25A5150", VA = "0x1825A6550")]
		public void Render(Act38sideFireworkSquadPluginItemViewModel viewModel, string selectAnimId)
		{
		}

		// Token: 0x06029FC5 RID: 171973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FC5")]
		[Address(RVA = "0x25A6770", Offset = "0x25A5370", VA = "0x1825A6770")]
		public Act38sideFireworkSquadPluginItemView()
		{
		}

		// Token: 0x0403C33B RID: 246587
		[Token(Token = "0x403C33B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act38sideFireworkSquadPluginItemView.Config[] _configList;

		// Token: 0x0403C33C RID: 246588
		[Token(Token = "0x403C33C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgAnimIcon;

		// Token: 0x0403C33D RID: 246589
		[Token(Token = "0x403C33D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x0403C33E RID: 246590
		[Token(Token = "0x403C33E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403C33F RID: 246591
		[Token(Token = "0x403C33F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelUnlock;

		// Token: 0x0403C340 RID: 246592
		[Token(Token = "0x403C340")]
		[FieldOffset(Offset = "0x40")]
		private string m_cachedAnimId;

		// Token: 0x0403C341 RID: 246593
		[Token(Token = "0x403C341")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403C343 RID: 246595
		[Token(Token = "0x403C343")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x0403C344 RID: 246596
		[Token(Token = "0x403C344")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x0403C345 RID: 246597
		[Token(Token = "0x403C345")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnItemClicked;

		// Token: 0x0403C346 RID: 246598
		[Token(Token = "0x403C346")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C347 RID: 246599
		[Token(Token = "0x403C347")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007437 RID: 29751
		[Token(Token = "0x2007437")]
		[Serializable]
		private struct Config
		{
			// Token: 0x0403C348 RID: 246600
			[Token(Token = "0x403C348")]
			[FieldOffset(Offset = "0x0")]
			public string animId;

			// Token: 0x0403C349 RID: 246601
			[Token(Token = "0x403C349")]
			[FieldOffset(Offset = "0x8")]
			public GameObject panelBkg;

			// Token: 0x0403C34A RID: 246602
			[Token(Token = "0x403C34A")]
			[FieldOffset(Offset = "0x10")]
			public GameObject panelSelectedBkg;

			// Token: 0x0403C34B RID: 246603
			[Token(Token = "0x403C34B")]
			[FieldOffset(Offset = "0x18")]
			public GameObject panelUnselectBkg;
		}
	}
}
