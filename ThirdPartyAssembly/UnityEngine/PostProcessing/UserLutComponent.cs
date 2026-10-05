using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000A5 RID: 165
	[Token(Token = "0x20000A5")]
	public sealed class UserLutComponent : PostProcessingComponentRenderTexture<UserLutModel>
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000346 RID: 838 RVA: 0x00003180 File Offset: 0x00001380
		[Token(Token = "0x17000046")]
		public override bool active
		{
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x5435610", Offset = "0x5434210", VA = "0x185435610", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x54353D0", Offset = "0x5433FD0", VA = "0x1854353D0", Slot = "10")]
		public override void Prepare(Material uberMaterial)
		{
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x5435230", Offset = "0x5433E30", VA = "0x185435230")]
		public void OnGUI()
		{
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x54355D0", Offset = "0x54341D0", VA = "0x1854355D0")]
		public UserLutComponent()
		{
		}

		// Token: 0x020000A6 RID: 166
		[Token(Token = "0x20000A6")]
		private static class Uniforms
		{
			// Token: 0x04000437 RID: 1079
			[Token(Token = "0x4000437")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _UserLut;

			// Token: 0x04000438 RID: 1080
			[Token(Token = "0x4000438")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _UserLut_Params;
		}
	}
}
