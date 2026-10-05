using System;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020034A7 RID: 13479
	[Token(Token = "0x20034A7")]
	public class AVGShaderProfile : MonoBehaviour, IHotfixable
	{
		// Token: 0x170032BF RID: 12991
		// (get) Token: 0x060157CD RID: 88013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170032BF")]
		public Shader avgCharSplitShader
		{
			[Token(Token = "0x60157CD")]
			[Address(RVA = "0xDF3C60", Offset = "0xDF2860", VA = "0x180DF3C60")]
			get
			{
				return null;
			}
		}

		// Token: 0x060157CE RID: 88014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60157CE")]
		[Address(RVA = "0xDF3A60", Offset = "0xDF2660", VA = "0x180DF3A60")]
		public AVGGlitchMaterialSettings GetGlitchSettingByName(string name)
		{
			return null;
		}

		// Token: 0x060157CF RID: 88015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60157CF")]
		[Address(RVA = "0xDF38C0", Offset = "0xDF24C0", VA = "0x180DF38C0")]
		public AVGChaosMaterialSettings GetChaosSettingByName(string name)
		{
			return null;
		}

		// Token: 0x060157D0 RID: 88016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157D0")]
		[Address(RVA = "0xDF3C00", Offset = "0xDF2800", VA = "0x180DF3C00")]
		public AVGShaderProfile()
		{
		}

		// Token: 0x04019BB4 RID: 105396
		[Token(Token = "0x4019BB4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Shader _avgCharSplitShader;

		// Token: 0x04019BB5 RID: 105397
		[Token(Token = "0x4019BB5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AVGGlitchMaterialSettings[] _glitchSettingsList;

		// Token: 0x04019BB6 RID: 105398
		[Token(Token = "0x4019BB6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AVGChaosMaterialSettings[] _chaosSettingsList;

		// Token: 0x04019BB7 RID: 105399
		[Token(Token = "0x4019BB7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_avgCharSplitShader;

		// Token: 0x04019BB8 RID: 105400
		[Token(Token = "0x4019BB8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetGlitchSettingByName;

		// Token: 0x04019BB9 RID: 105401
		[Token(Token = "0x4019BB9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetChaosSettingByName;

		// Token: 0x04019BBA RID: 105402
		[Token(Token = "0x4019BBA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
