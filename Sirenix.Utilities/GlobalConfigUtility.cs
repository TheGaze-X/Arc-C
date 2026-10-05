using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sirenix.Utilities
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	public static class GlobalConfigUtility<T> where T : ScriptableObject
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x00003134 File Offset: 0x00001334
		[Token(Token = "0x17000044")]
		public static bool HasInstanceLoaded
		{
			[Token(Token = "0x60002B9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002BA")]
		public static T GetInstance(string defaultAssetFolderPath, [Optional] string defaultFileNameWithoutExtension)
		{
			return null;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002BB")]
		internal static void LoadInstanceIfAssetExists(string assetPath, [Optional] string defaultFileNameWithoutExtension)
		{
		}

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T instance;
	}
}
