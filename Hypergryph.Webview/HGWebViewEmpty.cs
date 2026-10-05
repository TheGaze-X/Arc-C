using System;
using System.Collections;
using Il2CppDummyDll;

namespace Hypergryph.SDK
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	internal class HGWebViewEmpty : IUniWebview
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x4A30C60", Offset = "0x4A2F860", VA = "0x184A30C60", Slot = "4")]
		public void init(string env)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x4A30BD0", Offset = "0x4A2F7D0", VA = "0x184A30BD0", Slot = "12")]
		public void closeWebview()
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x4A30E80", Offset = "0x4A2FA80", VA = "0x184A30E80", Slot = "7")]
		public void isNew(string type)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x4A30DA0", Offset = "0x4A2F9A0", VA = "0x184A30DA0", Slot = "8")]
		public void isNew(string type, string urlParams)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x4A30CF0", Offset = "0x4A2F8F0", VA = "0x184A30CF0", Slot = "9")]
		public void isNewByCache(string type)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x4A31110", Offset = "0x4A2FD10", VA = "0x184A31110", Slot = "10")]
		public void loadWebview(string type, string userData)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x4A31030", Offset = "0x4A2FC30", VA = "0x184A31030", Slot = "11")]
		public void loadWebview(string type, string userData, string urlParams)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x4A313A0", Offset = "0x4A2FFA0", VA = "0x184A313A0", Slot = "13")]
		public void toastInsideWebview(int level, string message)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x4A31280", Offset = "0x4A2FE80", VA = "0x184A31280", Slot = "5")]
		public void startWebSupport()
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x4A31310", Offset = "0x4A2FF10", VA = "0x184A31310", Slot = "6")]
		public void stopWebSupport()
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x4A311E0", Offset = "0x4A2FDE0", VA = "0x184A311E0", Slot = "14")]
		public void preloadWebview(string type)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002054 File Offset: 0x00000254
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "15")]
		public bool checkPreloadStatus()
		{
			return default(bool);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x4A30F50", Offset = "0x4A2FB50", VA = "0x184A30F50", Slot = "16")]
		public void loadMiniWebview(string url, string userData, string customStyle)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x4A30A20", Offset = "0x4A2F620", VA = "0x184A30A20")]
		private static void _SendMessage(object value)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x4A30930", Offset = "0x4A2F530", VA = "0x184A30930")]
		private static IEnumerator _InvokeNextFrame(Action action)
		{
			return null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x4A309B0", Offset = "0x4A2F5B0", VA = "0x184A309B0")]
		private static void _Log(string msg)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HGWebViewEmpty()
		{
		}
	}
}
