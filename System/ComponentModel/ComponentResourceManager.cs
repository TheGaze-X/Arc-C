using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000182 RID: 386
	[Token(Token = "0x2000182")]
	public class ComponentResourceManager : ResourceManager
	{
		// Token: 0x060009DF RID: 2527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x513C020", Offset = "0x513AC20", VA = "0x18513C020")]
		public ComponentResourceManager()
		{
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x513C070", Offset = "0x513AC70", VA = "0x18513C070")]
		public ComponentResourceManager(Type t)
		{
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001F7")]
		private CultureInfo NeutralResourcesCulture
		{
			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x513C0D0", Offset = "0x513ACD0", VA = "0x18513C0D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x513BA20", Offset = "0x513A620", VA = "0x18513BA20")]
		public void ApplyResources(object value, string objectName)
		{
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x513B180", Offset = "0x5139D80", VA = "0x18513B180", Slot = "9")]
		public virtual void ApplyResources(object value, string objectName, CultureInfo culture)
		{
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x513BA80", Offset = "0x513A680", VA = "0x18513BA80")]
		private SortedList<string, object> FillResources(CultureInfo culture, out ResourceSet resourceSet)
		{
			return null;
		}

		// Token: 0x0400066C RID: 1644
		[Token(Token = "0x400066C")]
		[FieldOffset(Offset = "0x88")]
		private Hashtable _resourceSets;

		// Token: 0x0400066D RID: 1645
		[Token(Token = "0x400066D")]
		[FieldOffset(Offset = "0x90")]
		private CultureInfo _neutralResourcesCulture;
	}
}
