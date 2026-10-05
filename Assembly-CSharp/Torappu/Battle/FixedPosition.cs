using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x0200221B RID: 8731
	[Token(Token = "0x200221B")]
	public struct FixedPosition : ILocatable
	{
		// Token: 0x17001BA9 RID: 7081
		// (get) Token: 0x0600DBD3 RID: 56275 RVA: 0x00050520 File Offset: 0x0004E720
		[Token(Token = "0x17001BA9")]
		public Vector2 mapPosition
		{
			[Token(Token = "0x600DBD3")]
			[Address(RVA = "0x361F7F0", Offset = "0x361E3F0", VA = "0x18361F7F0", Slot = "4")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17001BAA RID: 7082
		// (get) Token: 0x0600DBD4 RID: 56276 RVA: 0x00050538 File Offset: 0x0004E738
		// (set) Token: 0x0600DBD5 RID: 56277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001BAA")]
		public Vector3 mapPositionV3
		{
			[Token(Token = "0x600DBD4")]
			[Address(RVA = "0x361F7D0", Offset = "0x361E3D0", VA = "0x18361F7D0", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600DBD5")]
			[Address(RVA = "0x361F830", Offset = "0x361E430", VA = "0x18361F830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001BAB RID: 7083
		// (get) Token: 0x0600DBD6 RID: 56278 RVA: 0x00050550 File Offset: 0x0004E750
		// (set) Token: 0x0600DBD7 RID: 56279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001BAB")]
		public Vector3 worldPosition
		{
			[Token(Token = "0x600DBD6")]
			[Address(RVA = "0x361F810", Offset = "0x361E410", VA = "0x18361F810", Slot = "6")]
			[CompilerGenerated]
			readonly get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600DBD7")]
			[Address(RVA = "0x361F840", Offset = "0x361E440", VA = "0x18361F840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001BAC RID: 7084
		// (get) Token: 0x0600DBD8 RID: 56280 RVA: 0x00050568 File Offset: 0x0004E768
		// (set) Token: 0x0600DBD9 RID: 56281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001BAC")]
		public GridPosition gridPosition
		{
			[Token(Token = "0x600DBD8")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "7")]
			[CompilerGenerated]
			readonly get
			{
				return default(GridPosition);
			}
			[Token(Token = "0x600DBD9")]
			[Address(RVA = "0x3244A50", Offset = "0x3243650", VA = "0x183244A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001BAD RID: 7085
		// (get) Token: 0x0600DBDA RID: 56282 RVA: 0x00050580 File Offset: 0x0004E780
		// (set) Token: 0x0600DBDB RID: 56283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001BAD")]
		public Vector2 faceTo
		{
			[Token(Token = "0x600DBDA")]
			[Address(RVA = "0x168B8C0", Offset = "0x168A4C0", VA = "0x18168B8C0", Slot = "8")]
			[CompilerGenerated]
			readonly get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600DBDB")]
			[Address(RVA = "0xEFAAF0", Offset = "0xEF96F0", VA = "0x180EFAAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001BAE RID: 7086
		// (get) Token: 0x0600DBDC RID: 56284 RVA: 0x00050598 File Offset: 0x0004E798
		[Token(Token = "0x17001BAE")]
		public float height
		{
			[Token(Token = "0x600DBDC")]
			[Address(RVA = "0x361F7B0", Offset = "0x361E3B0", VA = "0x18361F7B0", Slot = "9")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600DBDD RID: 56285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBDD")]
		[Address(RVA = "0x361F4A0", Offset = "0x361E0A0", VA = "0x18361F4A0")]
		public FixedPosition(Vector2 mapPos)
		{
		}

		// Token: 0x0600DBDE RID: 56286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBDE")]
		[Address(RVA = "0x361F520", Offset = "0x361E120", VA = "0x18361F520")]
		public FixedPosition(Vector2 mapPos, Vector2 faceTo)
		{
		}

		// Token: 0x0600DBDF RID: 56287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBDF")]
		[Address(RVA = "0x361F320", Offset = "0x361DF20", VA = "0x18361F320")]
		public FixedPosition(Vector3 mapPos)
		{
		}

		// Token: 0x0600DBE0 RID: 56288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBE0")]
		[Address(RVA = "0x361F2E0", Offset = "0x361DEE0", VA = "0x18361F2E0")]
		public FixedPosition(Vector3 mapPos, Vector2 faceTo)
		{
		}

		// Token: 0x0600DBE1 RID: 56289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBE1")]
		[Address(RVA = "0x361F690", Offset = "0x361E290", VA = "0x18361F690")]
		public FixedPosition(Vector2 mapPos, Vector2 faceTo, float height)
		{
		}

		// Token: 0x0600DBE2 RID: 56290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBE2")]
		[Address(RVA = "0x361F3B0", Offset = "0x361DFB0", VA = "0x18361F3B0")]
		public FixedPosition(ILocatable locatable)
		{
		}

		// Token: 0x0600DBE3 RID: 56291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBE3")]
		[Address(RVA = "0x361F540", Offset = "0x361E140", VA = "0x18361F540")]
		public FixedPosition(ILocatable locatable, Vector2 faceTo)
		{
		}

		// Token: 0x0600DBE4 RID: 56292 RVA: 0x000505B0 File Offset: 0x0004E7B0
		[Token(Token = "0x600DBE4")]
		[Address(RVA = "0x361F1E0", Offset = "0x361DDE0", VA = "0x18361F1E0")]
		public static FixedPosition FromWorldPosition(Vector3 worldPos)
		{
			return default(FixedPosition);
		}

		// Token: 0x0600DBE5 RID: 56293 RVA: 0x000505C8 File Offset: 0x0004E7C8
		[Token(Token = "0x600DBE5")]
		[Address(RVA = "0x361F050", Offset = "0x361DC50", VA = "0x18361F050")]
		public static FixedPosition FromWorldPosition(Vector3 worldPos, Vector2 faceTo)
		{
			return default(FixedPosition);
		}

		// Token: 0x0600DBE6 RID: 56294 RVA: 0x000505E0 File Offset: 0x0004E7E0
		[Token(Token = "0x600DBE6")]
		[Address(RVA = "0x361F120", Offset = "0x361DD20", VA = "0x18361F120")]
		public static FixedPosition FromWorldPosition(Vector3 worldPos, Vector2 faceTo, float height)
		{
			return default(FixedPosition);
		}
	}
}
