using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector.Internal
{
	// Token: 0x02007CB8 RID: 31928
	[Token(Token = "0x2007CB8")]
	public class fiPersistentEditorStorage
	{
		// Token: 0x0602C97D RID: 182653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C97D")]
		public static void Reset<T>(fiUnityObjectReference key)
		{
		}

		// Token: 0x0602C97E RID: 182654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C97E")]
		public static T Read<T>(fiUnityObjectReference key) where T : new()
		{
			return null;
		}

		// Token: 0x0602C97F RID: 182655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C97F")]
		private static fiBaseStorageComponent<T> GetStorageDictionary<T>(GameObject container)
		{
			return null;
		}

		// Token: 0x17006860 RID: 26720
		// (get) Token: 0x0602C980 RID: 182656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006860")]
		public static GameObject SceneStorage
		{
			[Token(Token = "0x602C980")]
			[Address(RVA = "0x2884F00", Offset = "0x2883B00", VA = "0x182884F00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006861 RID: 26721
		// (get) Token: 0x0602C981 RID: 182657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006861")]
		public static GameObject PrefabStorage
		{
			[Token(Token = "0x602C981")]
			[Address(RVA = "0x2884BD0", Offset = "0x28837D0", VA = "0x182884BD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C982 RID: 182658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C982")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public fiPersistentEditorStorage()
		{
		}

		// Token: 0x040403E2 RID: 263138
		[Token(Token = "0x40403E2")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<Type, Type> _cachedRealComponentTypes;

		// Token: 0x040403E3 RID: 263139
		[Token(Token = "0x40403E3")]
		private const string SceneStorageName = "fiPersistentEditorStorage";

		// Token: 0x040403E4 RID: 263140
		[Token(Token = "0x40403E4")]
		[FieldOffset(Offset = "0x8")]
		private static GameObject _cachedSceneStorage;

		// Token: 0x040403E5 RID: 263141
		[Token(Token = "0x40403E5")]
		[FieldOffset(Offset = "0x10")]
		private static string PrefabPath;

		// Token: 0x040403E6 RID: 263142
		[Token(Token = "0x40403E6")]
		[FieldOffset(Offset = "0x18")]
		private static GameObject _cachedPrefabStorage;
	}
}
