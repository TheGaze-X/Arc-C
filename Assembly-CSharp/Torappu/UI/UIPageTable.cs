using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003639 RID: 13881
	[Token(Token = "0x2003639")]
	[CreateAssetMenu(menuName = "Torappu/UI/Page Table")]
	[Serializable]
	public class UIPageTable : ScriptableObject
	{
		// Token: 0x06016197 RID: 90519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016197")]
		[Address(RVA = "0xEA5560", Offset = "0xEA4160", VA = "0x180EA5560")]
		public static IUIPageRouter MergeRouter(params UIPageTable[] holders)
		{
			return null;
		}

		// Token: 0x06016198 RID: 90520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016198")]
		[Address(RVA = "0xEA5550", Offset = "0xEA4150", VA = "0x180EA5550")]
		public static IUIPageRouter MergeRouter(params IUIPageRouter[] routers)
		{
			return null;
		}

		// Token: 0x06016199 RID: 90521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016199")]
		[Address(RVA = "0xEA5540", Offset = "0xEA4140", VA = "0x180EA5540")]
		public static IUIPageRouter MergeRouterWithoutCheck(params IUIPageRouter[] routers)
		{
			return null;
		}

		// Token: 0x0601619A RID: 90522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601619A")]
		[Address(RVA = "0xEA56B0", Offset = "0xEA42B0", VA = "0x180EA56B0")]
		private static IUIPageRouter _MergeRoutersImpl(IUIPageRouter[] routers, bool bCheckDuplicate)
		{
			return null;
		}

		// Token: 0x0601619B RID: 90523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601619B")]
		[Address(RVA = "0xEA58E0", Offset = "0xEA44E0", VA = "0x180EA58E0")]
		[Conditional("TEST")]
		[Conditional("UNITY_EDITOR")]
		private static void _TestOnlyAssertTrue(bool condition, [Optional] string desc)
		{
		}

		// Token: 0x0601619C RID: 90524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601619C")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		public UIPageTable()
		{
		}

		// Token: 0x0401A94D RID: 108877
		[Token(Token = "0x401A94D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<UIPageTable.PageConfig> _pages;

		// Token: 0x0200363A RID: 13882
		[Token(Token = "0x200363A")]
		[Serializable]
		public class PageConfig : IUIPageConfig
		{
			// Token: 0x0601619D RID: 90525 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601619D")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			public string GetName()
			{
				return null;
			}

			// Token: 0x0601619E RID: 90526 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601619E")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
			public UIPage LoadPage()
			{
				return null;
			}

			// Token: 0x0601619F RID: 90527 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601619F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PageConfig()
			{
			}

			// Token: 0x0401A94E RID: 108878
			[Token(Token = "0x401A94E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x0401A94F RID: 108879
			[Token(Token = "0x401A94F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIPage prefab;
		}

		// Token: 0x0200363B RID: 13883
		[Token(Token = "0x200363B")]
		private class PageRouter : IUIPageRouter
		{
			// Token: 0x060161A0 RID: 90528 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60161A0")]
			[Address(RVA = "0xE93890", Offset = "0xE92490", VA = "0x180E93890", Slot = "4")]
			public IEnumerable<IUIPageConfig> EnumPages()
			{
				return null;
			}

			// Token: 0x060161A1 RID: 90529 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60161A1")]
			[Address(RVA = "0xE93910", Offset = "0xE92510", VA = "0x180E93910", Slot = "5")]
			public IUIPageConfig GetPageByName(string name)
			{
				return null;
			}

			// Token: 0x060161A2 RID: 90530 RVA: 0x0008F6D0 File Offset: 0x0008D8D0
			[Token(Token = "0x60161A2")]
			[Address(RVA = "0xE93960", Offset = "0xE92560", VA = "0x180E93960")]
			public bool TryAddConfig(IUIPageConfig config)
			{
				return default(bool);
			}

			// Token: 0x060161A3 RID: 90531 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60161A3")]
			[Address(RVA = "0xE93A90", Offset = "0xE92690", VA = "0x180E93A90")]
			public PageRouter()
			{
			}

			// Token: 0x0401A950 RID: 108880
			[Token(Token = "0x401A950")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Dictionary<string, IUIPageConfig> m_configs;
		}
	}
}
