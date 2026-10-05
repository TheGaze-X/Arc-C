using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003EF0 RID: 16112
	[Token(Token = "0x2003EF0")]
	public abstract class SiracusaMapNavigationButtonBaseView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003BA7 RID: 15271
		// (get) Token: 0x06019007 RID: 102407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003BA7")]
		public string entryId
		{
			[Token(Token = "0x6019007")]
			[Address(RVA = "0x11B6310", Offset = "0x11B4F10", VA = "0x1811B6310")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003BA8 RID: 15272
		// (get) Token: 0x06019008 RID: 102408 RVA: 0x0009CA80 File Offset: 0x0009AC80
		[Token(Token = "0x17003BA8")]
		public SiracusaData.NavigationType entryType
		{
			[Token(Token = "0x6019008")]
			[Address(RVA = "0x11B6370", Offset = "0x11B4F70", VA = "0x1811B6370")]
			get
			{
				return SiracusaData.NavigationType.NONE;
			}
		}

		// Token: 0x17003BA9 RID: 15273
		// (get) Token: 0x06019009 RID: 102409 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601900A RID: 102410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BA9")]
		public Action<string, SiracusaData.NavigationType> eventOnEntryClick
		{
			[Token(Token = "0x6019009")]
			[Address(RVA = "0x11B63D0", Offset = "0x11B4FD0", VA = "0x1811B63D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601900A")]
			[Address(RVA = "0x11B6430", Offset = "0x11B5030", VA = "0x1811B6430")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601900B RID: 102411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601900B")]
		[Address(RVA = "0x11B61E0", Offset = "0x11B4DE0", VA = "0x1811B61E0", Slot = "4")]
		public virtual void Render(SiracusaMapNavigationDetailViewModel viewModel)
		{
		}

		// Token: 0x0601900C RID: 102412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601900C")]
		[Address(RVA = "0x11B62B0", Offset = "0x11B4EB0", VA = "0x1811B62B0")]
		protected SiracusaMapNavigationButtonBaseView()
		{
		}

		// Token: 0x0401EE63 RID: 126563
		[Token(Token = "0x401EE63")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected string _entryId;

		// Token: 0x0401EE64 RID: 126564
		[Token(Token = "0x401EE64")]
		[FieldOffset(Offset = "0x20")]
		protected SiracusaMapNavigationDetailViewModel m_cachedViewModel;

		// Token: 0x0401EE65 RID: 126565
		[Token(Token = "0x401EE65")]
		[FieldOffset(Offset = "0x28")]
		protected SiracusaData.NavigationType m_entryType;

		// Token: 0x0401EE67 RID: 126567
		[Token(Token = "0x401EE67")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_entryId;

		// Token: 0x0401EE68 RID: 126568
		[Token(Token = "0x401EE68")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_entryType;

		// Token: 0x0401EE69 RID: 126569
		[Token(Token = "0x401EE69")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_eventOnEntryClick;

		// Token: 0x0401EE6A RID: 126570
		[Token(Token = "0x401EE6A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_eventOnEntryClick;

		// Token: 0x0401EE6B RID: 126571
		[Token(Token = "0x401EE6B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401EE6C RID: 126572
		[Token(Token = "0x401EE6C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
