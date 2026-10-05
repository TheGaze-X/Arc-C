using System;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CC8 RID: 7368
	[Token(Token = "0x2001CC8")]
	[RequireComponent(typeof(Text))]
	public class BuildingSMStationNumView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170015E4 RID: 5604
		// (get) Token: 0x0600B679 RID: 46713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015E4")]
		public Text text
		{
			[Token(Token = "0x600B679")]
			[Address(RVA = "0x33081E0", Offset = "0x3306DE0", VA = "0x1833081E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B67A RID: 46714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B67A")]
		[Address(RVA = "0x3307C00", Offset = "0x3306800", VA = "0x183307C00")]
		public void Render(int num, int limit)
		{
		}

		// Token: 0x0600B67B RID: 46715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B67B")]
		[Address(RVA = "0x3307ED0", Offset = "0x3306AD0", VA = "0x183307ED0")]
		private string _MakeRichNumber(int num, Color zeroColor, Color otherColor)
		{
			return null;
		}

		// Token: 0x0600B67C RID: 46716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B67C")]
		[Address(RVA = "0x3308120", Offset = "0x3306D20", VA = "0x183308120")]
		public BuildingSMStationNumView()
		{
		}

		// Token: 0x0400B392 RID: 45970
		[Token(Token = "0x400B392")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _disableColor;

		// Token: 0x0400B393 RID: 45971
		[Token(Token = "0x400B393")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _hilightColor;

		// Token: 0x0400B394 RID: 45972
		[Token(Token = "0x400B394")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _normalColor;

		// Token: 0x0400B395 RID: 45973
		[Token(Token = "0x400B395")]
		[FieldOffset(Offset = "0x48")]
		private Text m_text;

		// Token: 0x0400B396 RID: 45974
		[Token(Token = "0x400B396")]
		[FieldOffset(Offset = "0x50")]
		private int m_num;

		// Token: 0x0400B397 RID: 45975
		[Token(Token = "0x400B397")]
		[FieldOffset(Offset = "0x54")]
		private int m_limit;

		// Token: 0x0400B398 RID: 45976
		[Token(Token = "0x400B398")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x0400B399 RID: 45977
		[Token(Token = "0x400B399")]
		[FieldOffset(Offset = "0x60")]
		private StringBuilder m_sharedBuilder;

		// Token: 0x0400B39A RID: 45978
		[Token(Token = "0x400B39A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_text;

		// Token: 0x0400B39B RID: 45979
		[Token(Token = "0x400B39B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B39C RID: 45980
		[Token(Token = "0x400B39C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__MakeRichNumber;

		// Token: 0x0400B39D RID: 45981
		[Token(Token = "0x400B39D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
