using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace YoStar.SDK.UIWidgets
{
	// Token: 0x020000CB RID: 203
	[Token(Token = "0x20000CB")]
	public static class UIWidgetUtility
	{
		// Token: 0x06000578 RID: 1400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000578")]
		public static T Find<T>(string name) where T : UIWidget
		{
			return null;
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000579")]
		public static void Finds<T>(string name) where T : UIWidget
		{
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x5C35830", Offset = "0x5C34430", VA = "0x185C35830")]
		private static void OnSceneUnloaded(Scene scene)
		{
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x5C34950", Offset = "0x5C33550", VA = "0x185C34950")]
		private static void ChangedActiveScene(Scene current, Scene next)
		{
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600057D")]
		public static T[] FindAll<T>(string name) where T : UIWidget
		{
			return null;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600057E")]
		public static T[] FindAll<T>() where T : UIWidget
		{
			return null;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x5C34CC0", Offset = "0x5C338C0", VA = "0x185C34CC0")]
		public static string ColorToHex(Color32 color)
		{
			return null;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00002B04 File Offset: 0x00000D04
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x5C35220", Offset = "0x5C33E20", VA = "0x185C35220")]
		public static Color HexToColor(string hex)
		{
			return default(Color);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x5C34D50", Offset = "0x5C33950", VA = "0x185C34D50")]
		public static string HTMLString(string value, Color color, bool isBold = false, int fontSize = -1)
		{
			return null;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x5C349C0", Offset = "0x5C335C0", VA = "0x185C349C0")]
		public static string ColorString(string value, Color color)
		{
			return null;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x5C358A0", Offset = "0x5C344A0", VA = "0x185C358A0")]
		public static string Replace(string source, string oldString, string newString)
		{
			return null;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00002B1C File Offset: 0x00000D1C
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x5C35760", Offset = "0x5C34360", VA = "0x185C35760")]
		public static bool IsNumeric(object expression)
		{
			return default(bool);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00002B34 File Offset: 0x00000D34
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x5C354F0", Offset = "0x5C340F0", VA = "0x185C354F0")]
		public static bool IsInteger(Type value)
		{
			return default(bool);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00002B4C File Offset: 0x00000D4C
		[Token(Token = "0x6000586")]
		[Address(RVA = "0x5C35410", Offset = "0x5C34010", VA = "0x185C35410")]
		public static bool IsFloat(Type value)
		{
			return default(bool);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000587")]
		private static void CheckIsEnum<T>(bool withFlags)
		{
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00002B64 File Offset: 0x00000D64
		[Token(Token = "0x6000588")]
		public static bool HasFlag<T>(this T value, T flag) where T : struct
		{
			return default(bool);
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000052")]
		private static CoroutineHandler Handler
		{
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x5C35A70", Offset = "0x5C34670", VA = "0x185C35A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, List<UIWidget>> widgetCache;

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x8")]
		private static CoroutineHandler m_CoroutineHandler;
	}
}
