using System;
using System.Collections;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YoStar.SDK.Util
{
	// Token: 0x020000AF RID: 175
	[Token(Token = "0x20000AF")]
	public class ResourceUtils
	{
		// Token: 0x060004B3 RID: 1203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B3")]
		public static T Load<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60004B4")]
		public static void LoadAsync<T>(string path, UnityAction<T> unityAction) where T : UnityEngine.Object
		{
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B5")]
		private static IEnumerator LoadAsyncEnumerator<T>(string path, UnityAction<T> unityAction) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B6")]
		public static Task<T> LoadAsync<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x5C153D0", Offset = "0x5C13FD0", VA = "0x185C153D0")]
		public static Sprite LoadSprite(string path)
		{
			return null;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ResourceUtils()
		{
		}
	}
}
