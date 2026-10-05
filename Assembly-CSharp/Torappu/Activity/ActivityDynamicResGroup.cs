using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D48 RID: 27976
	[Token(Token = "0x2006D48")]
	public class ActivityDynamicResGroup : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005E54 RID: 24148
		// (get) Token: 0x06027E07 RID: 163335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E54")]
		public List<ActivityDynamicImage> DynamicImages
		{
			[Token(Token = "0x6027E07")]
			[Address(RVA = "0x22F0BE0", Offset = "0x22EF7E0", VA = "0x1822F0BE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005E55 RID: 24149
		// (get) Token: 0x06027E08 RID: 163336 RVA: 0x000CFBE8 File Offset: 0x000CDDE8
		[Token(Token = "0x17005E55")]
		public int Count
		{
			[Token(Token = "0x6027E08")]
			[Address(RVA = "0x22F0B70", Offset = "0x22EF770", VA = "0x1822F0B70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06027E09 RID: 163337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E09")]
		[Address(RVA = "0x22F0480", Offset = "0x22EF080", VA = "0x1822F0480")]
		[Inspect]
		public void EditorOnlyCollectDynamicImages()
		{
		}

		// Token: 0x06027E0A RID: 163338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E0A")]
		[Address(RVA = "0x22F0610", Offset = "0x22EF210", VA = "0x1822F0610")]
		public void RenderAll(string actId)
		{
		}

		// Token: 0x06027E0B RID: 163339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E0B")]
		[Address(RVA = "0x22F0740", Offset = "0x22EF340", VA = "0x1822F0740")]
		public void SetColor(string color)
		{
		}

		// Token: 0x06027E0C RID: 163340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E0C")]
		[Address(RVA = "0x22F0A70", Offset = "0x22EF670", VA = "0x1822F0A70")]
		public ActivityDynamicResGroup()
		{
		}

		// Token: 0x0403886B RID: 231531
		[Token(Token = "0x403886B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<ActivityDynamicImage> _dynamicImages;

		// Token: 0x0403886C RID: 231532
		[Token(Token = "0x403886C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Text> _colorTexts;

		// Token: 0x0403886D RID: 231533
		[Token(Token = "0x403886D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_DynamicImages;

		// Token: 0x0403886E RID: 231534
		[Token(Token = "0x403886E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_Count;

		// Token: 0x0403886F RID: 231535
		[Token(Token = "0x403886F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EditorOnlyCollectDynamicImages;

		// Token: 0x04038870 RID: 231536
		[Token(Token = "0x4038870")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderAll;

		// Token: 0x04038871 RID: 231537
		[Token(Token = "0x4038871")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetColor;

		// Token: 0x04038872 RID: 231538
		[Token(Token = "0x4038872")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
