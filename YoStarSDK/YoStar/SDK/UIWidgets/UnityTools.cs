using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;

namespace YoStar.SDK.UIWidgets
{
	// Token: 0x020000EC RID: 236
	[Token(Token = "0x20000EC")]
	public static class UnityTools
	{
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000070")]
		private static CoroutineHandler Handler
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x5C38D40", Offset = "0x5C37940", VA = "0x185C38D40")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000653")]
		[Address(RVA = "0x5C38630", Offset = "0x5C37230", VA = "0x185C38630")]
		public static void PlaySound(AudioClip clip, float volumeScale, [Optional] AudioMixerGroup audioMixerGroup)
		{
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0000317C File Offset: 0x0000137C
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x5C37220", Offset = "0x5C35E20", VA = "0x185C37220")]
		public static bool IsPointerOverUI()
		{
			return default(bool);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x5C36E30", Offset = "0x5C35A30", VA = "0x185C36E30")]
		public static GameObject FindChild(this GameObject target, string name, bool includeInactive)
		{
			return null;
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x5C38B50", Offset = "0x5C37750", VA = "0x185C38B50")]
		public static void Stretch(this RectTransform rectTransform, RectOffset offset)
		{
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x5C38A10", Offset = "0x5C37610", VA = "0x185C38A10")]
		public static void Stretch(this RectTransform rectTransform)
		{
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000658")]
		public static void SetActiveObjectsOfType<T>(bool state) where T : Component
		{
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x5C37130", Offset = "0x5C35D30", VA = "0x185C37130")]
		public static void IgnoreCollision(GameObject gameObject1, GameObject gameObject2)
		{
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00003194 File Offset: 0x00001394
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x5C36FC0", Offset = "0x5C35BC0", VA = "0x185C36FC0")]
		public static Bounds GetBounds(GameObject obj)
		{
			return default(Bounds);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x5C374E0", Offset = "0x5C360E0", VA = "0x185C374E0")]
		public static string KeyToCaption(KeyCode key)
		{
			return null;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x5C388B0", Offset = "0x5C374B0", VA = "0x185C388B0")]
		public static Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x5C388E0", Offset = "0x5C374E0", VA = "0x185C388E0")]
		public static Coroutine StartCoroutine(string methodName, object value)
		{
			return null;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x5C38920", Offset = "0x5C37520", VA = "0x185C38920")]
		public static Coroutine StartCoroutine(string methodName)
		{
			return null;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x5C389E0", Offset = "0x5C375E0", VA = "0x185C389E0")]
		public static void StopCoroutine(IEnumerator routine)
		{
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x5C389B0", Offset = "0x5C375B0", VA = "0x185C389B0")]
		public static void StopCoroutine(string methodName)
		{
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x5C38980", Offset = "0x5C37580", VA = "0x185C38980")]
		public static void StopCoroutine(Coroutine routine)
		{
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x5C38950", Offset = "0x5C37550", VA = "0x185C38950")]
		public static void StopAllCoroutines()
		{
		}

		// Token: 0x0400037D RID: 893
		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CoroutineHandler m_CoroutineHandler;

		// Token: 0x0400037E RID: 894
		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static AudioSource audioSource;
	}
}
