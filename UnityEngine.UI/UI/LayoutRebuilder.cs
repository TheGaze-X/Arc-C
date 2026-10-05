using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Events;
using UnityEngine.Pool;

namespace UnityEngine.UI
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	public class LayoutRebuilder : ICanvasElement
	{
		// Token: 0x06000320 RID: 800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x5B651B0", Offset = "0x5B63DB0", VA = "0x185B651B0")]
		private void Initialize(RectTransform controller)
		{
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x5B64FF0", Offset = "0x5B63BF0", VA = "0x185B64FF0")]
		private void Clear()
		{
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x5B65FB0", Offset = "0x5B64BB0", VA = "0x185B65FB0")]
		private static void ReapplyDrivenProperties(RectTransform driven)
		{
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E3")]
		public Transform transform
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00003330 File Offset: 0x00001530
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x5B65210", Offset = "0x5B63E10", VA = "0x185B65210", Slot = "8")]
		public bool IsDestroyed()
		{
			return default(bool);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x5B66380", Offset = "0x5B64F80", VA = "0x185B66380")]
		private static void StripDisabledBehavioursFromList(List<Component> components)
		{
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x5B650A0", Offset = "0x5B63CA0", VA = "0x185B650A0")]
		public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot)
		{
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x5B66000", Offset = "0x5B64C00", VA = "0x185B66000", Slot = "4")]
		public void Rebuild(CanvasUpdate executing)
		{
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x5B65C30", Offset = "0x5B64830", VA = "0x185B65C30")]
		private void PerformLayoutControl(RectTransform rect, UnityAction<Component> action)
		{
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x5B65980", Offset = "0x5B64580", VA = "0x185B65980")]
		private void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action)
		{
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x5B652E0", Offset = "0x5B63EE0", VA = "0x185B652E0")]
		public static void MarkLayoutForRebuild(RectTransform rect)
		{
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00003348 File Offset: 0x00001548
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x5B66520", Offset = "0x5B65120", VA = "0x185B66520")]
		private static bool ValidController(RectTransform layoutRoot, List<Component> comps)
		{
			return default(bool);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x5B657F0", Offset = "0x5B643F0", VA = "0x185B657F0")]
		private static void MarkLayoutRootForRebuild(RectTransform controller)
		{
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x5B65260", Offset = "0x5B63E60", VA = "0x185B65260", Slot = "6")]
		public void LayoutComplete()
		{
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		public void GraphicUpdateComplete()
		{
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00003360 File Offset: 0x00001560
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00003378 File Offset: 0x00001578
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x5B65020", Offset = "0x5B63C20", VA = "0x185B65020", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x5B664A0", Offset = "0x5B650A0", VA = "0x185B664A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LayoutRebuilder()
		{
		}

		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x10")]
		private RectTransform m_ToRebuild;

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x18")]
		private int m_CachedHashFromTransform;

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x0")]
		private static ObjectPool<LayoutRebuilder> s_Rebuilders;
	}
}
