using System;
using CriWare;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Video
{
	// Token: 0x020016CA RID: 5834
	[Token(Token = "0x20016CA")]
	public class VideoManager : PersistentSingleton<VideoManager>, IHotfixable, ISingletonNotAutoCreate
	{
		// Token: 0x060093E4 RID: 37860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60093E4")]
		[Address(RVA = "0x2B41AE0", Offset = "0x2B406E0", VA = "0x182B41AE0")]
		public AbstractMediaPlayerHolder InstaniateMediaPlayer(ILoadAsset assetLoader, Transform container)
		{
			return null;
		}

		// Token: 0x060093E5 RID: 37861 RVA: 0x00039B70 File Offset: 0x00037D70
		[Token(Token = "0x60093E5")]
		[Address(RVA = "0x2B419E0", Offset = "0x2B405E0", VA = "0x182B419E0")]
		public bool CheckVideoExist(string path)
		{
			return default(bool);
		}

		// Token: 0x060093E6 RID: 37862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60093E6")]
		[Address(RVA = "0x2B41A60", Offset = "0x2B40660", VA = "0x182B41A60")]
		public string GetVideoFullPath(string path)
		{
			return null;
		}

		// Token: 0x060093E7 RID: 37863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60093E7")]
		[Address(RVA = "0x2B41F40", Offset = "0x2B40B40", VA = "0x182B41F40")]
		public string TreatVideoPath(string path)
		{
			return null;
		}

		// Token: 0x060093E8 RID: 37864 RVA: 0x00039B88 File Offset: 0x00037D88
		[Token(Token = "0x60093E8")]
		[Address(RVA = "0x2B41D30", Offset = "0x2B40930", VA = "0x182B41D30")]
		public bool IsMp4VideoPath(string path)
		{
			return default(bool);
		}

		// Token: 0x060093E9 RID: 37865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093E9")]
		[Address(RVA = "0x2B41DC0", Offset = "0x2B409C0", VA = "0x182B41DC0")]
		public void OnInitSDK(bool isInitScene)
		{
		}

		// Token: 0x060093EA RID: 37866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093EA")]
		[Address(RVA = "0x2B41FF0", Offset = "0x2B40BF0", VA = "0x182B41FF0")]
		public VideoManager()
		{
		}

		// Token: 0x040089AF RID: 35247
		[Token(Token = "0x40089AF")]
		[FieldOffset(Offset = "0x18")]
		private CriWareInitializer m_criWareInitializer;

		// Token: 0x040089B0 RID: 35248
		[Token(Token = "0x40089B0")]
		[FieldOffset(Offset = "0x20")]
		private CriWareErrorHandler m_errorHandler;

		// Token: 0x040089B1 RID: 35249
		[Token(Token = "0x40089B1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InstaniateMediaPlayer;

		// Token: 0x040089B2 RID: 35250
		[Token(Token = "0x40089B2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckVideoExist;

		// Token: 0x040089B3 RID: 35251
		[Token(Token = "0x40089B3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetVideoFullPath;

		// Token: 0x040089B4 RID: 35252
		[Token(Token = "0x40089B4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TreatVideoPath;

		// Token: 0x040089B5 RID: 35253
		[Token(Token = "0x40089B5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsMp4VideoPath;

		// Token: 0x040089B6 RID: 35254
		[Token(Token = "0x40089B6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInitSDK;

		// Token: 0x040089B7 RID: 35255
		[Token(Token = "0x40089B7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020016CB RID: 5835
		[Token(Token = "0x20016CB")]
		public enum VideoType
		{
			// Token: 0x040089B9 RID: 35257
			[Token(Token = "0x40089B9")]
			AVPRO,
			// Token: 0x040089BA RID: 35258
			[Token(Token = "0x40089BA")]
			SOFDEC
		}
	}
}
