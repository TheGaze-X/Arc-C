using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x0200213E RID: 8510
	[Token(Token = "0x200213E")]
	public class SpineShaderManager
	{
		// Token: 0x0600D13E RID: 53566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D13E")]
		[Address(RVA = "0x3539A80", Offset = "0x3538680", VA = "0x183539A80")]
		public void SynReplaceShaderInfo(SpineShaderManager.ReplaceOptions options)
		{
		}

		// Token: 0x0600D13F RID: 53567 RVA: 0x0004B660 File Offset: 0x00049860
		[Token(Token = "0x600D13F")]
		[Address(RVA = "0x3539510", Offset = "0x3538110", VA = "0x183539510")]
		public bool CheckGlobalSpineShaderReplacement(Material sharedMat, Shader originShader, out Shader replaceShader)
		{
			return default(bool);
		}

		// Token: 0x0600D140 RID: 53568 RVA: 0x0004B678 File Offset: 0x00049878
		[Token(Token = "0x600D140")]
		[Address(RVA = "0x3539660", Offset = "0x3538260", VA = "0x183539660")]
		public bool CheckTileSpineShaderReplacement(Vector2 tileWorldPos, Material sharedMat, MaterialPropertyBlock materialBlock, Shader originShader, out Shader replaceShader)
		{
			return default(bool);
		}

		// Token: 0x0600D141 RID: 53569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D141")]
		[Address(RVA = "0x35399C0", Offset = "0x35385C0", VA = "0x1835399C0")]
		public void ResetSpineShader(Material sharedMat)
		{
		}

		// Token: 0x0600D142 RID: 53570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D142")]
		[Address(RVA = "0x35397F0", Offset = "0x35383F0", VA = "0x1835397F0")]
		public void ResetAllSpineShaders()
		{
		}

		// Token: 0x0600D143 RID: 53571 RVA: 0x0004B690 File Offset: 0x00049890
		[Token(Token = "0x600D143")]
		[Address(RVA = "0x3539B60", Offset = "0x3538760", VA = "0x183539B60")]
		private bool _CheckSpineInTilePos(Vector2 spineTilePos)
		{
			return default(bool);
		}

		// Token: 0x0600D144 RID: 53572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D144")]
		[Address(RVA = "0x3539DD0", Offset = "0x35389D0", VA = "0x183539DD0")]
		private Shader _FindDefaultSpineShader()
		{
			return null;
		}

		// Token: 0x0600D145 RID: 53573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D145")]
		[Address(RVA = "0x3539E60", Offset = "0x3538A60", VA = "0x183539E60")]
		public SpineShaderManager()
		{
		}

		// Token: 0x0400DFB6 RID: 57270
		[Token(Token = "0x400DFB6")]
		[FieldOffset(Offset = "0x10")]
		private SpineShaderManager.ReplaceOptions m_replaceOptions;

		// Token: 0x0400DFB7 RID: 57271
		[Token(Token = "0x400DFB7")]
		[FieldOffset(Offset = "0x30")]
		private bool m_shaderReplaced;

		// Token: 0x0400DFB8 RID: 57272
		[Token(Token = "0x400DFB8")]
		[FieldOffset(Offset = "0x38")]
		private Shader m_defaultOriginShader;

		// Token: 0x0400DFB9 RID: 57273
		[Token(Token = "0x400DFB9")]
		[FieldOffset(Offset = "0x40")]
		private ListDict<Material, Shader> m_originShaderMap;

		// Token: 0x0200213F RID: 8511
		[Token(Token = "0x200213F")]
		public enum ReplaceType
		{
			// Token: 0x0400DFBB RID: 57275
			[Token(Token = "0x400DFBB")]
			ALL,
			// Token: 0x0400DFBC RID: 57276
			[Token(Token = "0x400DFBC")]
			TILE_BASED
		}

		// Token: 0x02002140 RID: 8512
		[Token(Token = "0x2002140")]
		public struct ReplaceOptions
		{
			// Token: 0x0400DFBD RID: 57277
			[Token(Token = "0x400DFBD")]
			[FieldOffset(Offset = "0x0")]
			public SpineShaderManager.ReplaceType type;

			// Token: 0x0400DFBE RID: 57278
			[Token(Token = "0x400DFBE")]
			[FieldOffset(Offset = "0x8")]
			public Shader replaceSpineShader;

			// Token: 0x0400DFBF RID: 57279
			[Token(Token = "0x400DFBF")]
			[FieldOffset(Offset = "0x10")]
			public string flagPropertyName;

			// Token: 0x0400DFC0 RID: 57280
			[Token(Token = "0x400DFC0")]
			[FieldOffset(Offset = "0x18")]
			public IList<Vector2> tilePosList;
		}
	}
}
