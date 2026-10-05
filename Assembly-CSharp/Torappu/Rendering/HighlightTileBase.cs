using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Rendering
{
	// Token: 0x0200205F RID: 8287
	[Token(Token = "0x200205F")]
	[RequireComponent(typeof(MeshRenderer))]
	public class HighlightTileBase<ProfileT> : HighlightTileEffect where ProfileT : HighlightTileProfile
	{
		// Token: 0x17001835 RID: 6197
		// (get) Token: 0x0600CC2B RID: 52267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001835")]
		public ProfileT profile
		{
			[Token(Token = "0x600CC2B")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600CC2C RID: 52268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC2C")]
		public HighlightTileBase()
		{
		}

		// Token: 0x0400D6A8 RID: 54952
		[Token(Token = "0x400D6A8")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private ProfileT _profile;
	}
}
