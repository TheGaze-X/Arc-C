using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F76 RID: 8054
	[Token(Token = "0x2001F76")]
	[RequireComponent(typeof(Text), typeof(ContentSizeFitter))]
	public class AVGTypeWriterText : MonoBehaviour, IHotfixable
	{
		// Token: 0x170017AB RID: 6059
		// (get) Token: 0x0600C822 RID: 51234 RVA: 0x00048CC0 File Offset: 0x00046EC0
		[Token(Token = "0x170017AB")]
		public bool isTyping
		{
			[Token(Token = "0x600C822")]
			[Address(RVA = "0x3495D40", Offset = "0x3494940", VA = "0x183495D40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170017AC RID: 6060
		// (get) Token: 0x0600C823 RID: 51235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017AC")]
		public string message
		{
			[Token(Token = "0x600C823")]
			[Address(RVA = "0x3495E20", Offset = "0x3494A20", VA = "0x183495E20")]
			get
			{
				return null;
			}
		}

		// Token: 0x170017AD RID: 6061
		// (get) Token: 0x0600C824 RID: 51236 RVA: 0x00048CD8 File Offset: 0x00046ED8
		[Token(Token = "0x170017AD")]
		public int messageLength
		{
			[Token(Token = "0x600C824")]
			[Address(RVA = "0x3495DA0", Offset = "0x34949A0", VA = "0x183495DA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170017AE RID: 6062
		// (get) Token: 0x0600C825 RID: 51237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017AE")]
		protected Text text
		{
			[Token(Token = "0x600C825")]
			[Address(RVA = "0x3495EE0", Offset = "0x3494AE0", VA = "0x183495EE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x0600C826 RID: 51238 RVA: 0x00048CF0 File Offset: 0x00046EF0
		// (set) Token: 0x0600C827 RID: 51239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170017AF")]
		public float typeWriterDelay
		{
			[Token(Token = "0x600C826")]
			[Address(RVA = "0x3495FB0", Offset = "0x3494BB0", VA = "0x183495FB0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600C827")]
			[Address(RVA = "0x3496010", Offset = "0x3494C10", VA = "0x183496010")]
			set
			{
			}
		}

		// Token: 0x170017B0 RID: 6064
		// (get) Token: 0x0600C828 RID: 51240 RVA: 0x00048D08 File Offset: 0x00046F08
		[Token(Token = "0x170017B0")]
		public float originDelay
		{
			[Token(Token = "0x600C828")]
			[Address(RVA = "0x3495E80", Offset = "0x3494A80", VA = "0x183495E80")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600C829 RID: 51241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C829")]
		[Address(RVA = "0x3495160", Offset = "0x3493D60", VA = "0x183495160")]
		public void OnReset()
		{
		}

		// Token: 0x0600C82A RID: 51242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C82A")]
		[Address(RVA = "0x3494F20", Offset = "0x3493B20", VA = "0x183494F20")]
		public void BeginText(string message, [Optional] Action onTypeEnd)
		{
		}

		// Token: 0x0600C82B RID: 51243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C82B")]
		[Address(RVA = "0x3494C30", Offset = "0x3493830", VA = "0x183494C30")]
		public void AppendText(string message, Action onTypeEnd)
		{
		}

		// Token: 0x0600C82C RID: 51244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C82C")]
		[Address(RVA = "0x3495330", Offset = "0x3493F30", VA = "0x183495330")]
		public void TryFinish()
		{
		}

		// Token: 0x0600C82D RID: 51245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C82D")]
		[Address(RVA = "0x34951D0", Offset = "0x3493DD0", VA = "0x1834951D0")]
		public void StopTypingSilently()
		{
		}

		// Token: 0x0600C82E RID: 51246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C82E")]
		[Address(RVA = "0x3495280", Offset = "0x3493E80", VA = "0x183495280")]
		public void TryCutMessage(int length)
		{
		}

		// Token: 0x0600C82F RID: 51247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C82F")]
		[Address(RVA = "0x34957D0", Offset = "0x34943D0", VA = "0x1834957D0")]
		private void _FinishTyping(bool invokeTypeEnd)
		{
		}

		// Token: 0x0600C830 RID: 51248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C830")]
		[Address(RVA = "0x34956C0", Offset = "0x34942C0", VA = "0x1834956C0")]
		private void _ClearMessage()
		{
		}

		// Token: 0x0600C831 RID: 51249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C831")]
		[Address(RVA = "0x3495AA0", Offset = "0x34946A0", VA = "0x183495AA0")]
		private IEnumerable<string> _GetTextMessageGenerator()
		{
			return null;
		}

		// Token: 0x0600C832 RID: 51250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C832")]
		[Address(RVA = "0x34959E0", Offset = "0x34945E0", VA = "0x1834959E0")]
		private IEnumerable<string> _GetMultilineTextMessageGenerator()
		{
			return null;
		}

		// Token: 0x0600C833 RID: 51251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C833")]
		[Address(RVA = "0x3495B50", Offset = "0x3494750", VA = "0x183495B50")]
		private void _UpdateMaxWidth()
		{
		}

		// Token: 0x0600C834 RID: 51252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C834")]
		[Address(RVA = "0x3495570", Offset = "0x3494170", VA = "0x183495570")]
		private static void _AppendHiddenString(StringBuilder sb, string hiddenString)
		{
		}

		// Token: 0x0600C835 RID: 51253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C835")]
		[Address(RVA = "0x3494E60", Offset = "0x3493A60", VA = "0x183494E60")]
		private void Awake()
		{
		}

		// Token: 0x0600C836 RID: 51254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C836")]
		[Address(RVA = "0x34953E0", Offset = "0x3493FE0", VA = "0x1834953E0")]
		private void Update()
		{
		}

		// Token: 0x0600C837 RID: 51255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C837")]
		[Address(RVA = "0x3495C60", Offset = "0x3494860", VA = "0x183495C60")]
		public AVGTypeWriterText()
		{
		}

		// Token: 0x0400CE92 RID: 52882
		[Token(Token = "0x400CE92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _typeWriterDelay;

		// Token: 0x0400CE93 RID: 52883
		[Token(Token = "0x400CE93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool _onMiddle;

		// Token: 0x0400CE94 RID: 52884
		[Token(Token = "0x400CE94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxWidth;

		// Token: 0x0400CE95 RID: 52885
		[Token(Token = "0x400CE95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _doNotParseSpecialChars;

		// Token: 0x0400CE96 RID: 52886
		[Token(Token = "0x400CE96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text m_text;

		// Token: 0x0400CE97 RID: 52887
		[Token(Token = "0x400CE97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string m_message;

		// Token: 0x0400CE98 RID: 52888
		[Token(Token = "0x400CE98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Action m_onTypeEnd;

		// Token: 0x0400CE99 RID: 52889
		[Token(Token = "0x400CE99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private double m_typerTime;

		// Token: 0x0400CE9A RID: 52890
		[Token(Token = "0x400CE9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_typing;

		// Token: 0x0400CE9B RID: 52891
		[Token(Token = "0x400CE9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool m_onMiddle;

		// Token: 0x0400CE9C RID: 52892
		[Token(Token = "0x400CE9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private StringBuilder m_sb;

		// Token: 0x0400CE9D RID: 52893
		[Token(Token = "0x400CE9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform m_rect;

		// Token: 0x0400CE9E RID: 52894
		[Token(Token = "0x400CE9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ContentSizeFitter m_sizeFitter;

		// Token: 0x0400CE9F RID: 52895
		[Token(Token = "0x400CE9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_typeWriterDelay;

		// Token: 0x0400CEA0 RID: 52896
		[Token(Token = "0x400CEA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private IEnumerator<string> m_textMessageIterator;

		// Token: 0x0400CEA1 RID: 52897
		[Token(Token = "0x400CEA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int m_cachedMultilineTextLenth;

		// Token: 0x0400CEA2 RID: 52898
		[Token(Token = "0x400CEA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private bool m_isMultiline;

		// Token: 0x0400CEA3 RID: 52899
		[Token(Token = "0x400CEA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isTyping;

		// Token: 0x0400CEA4 RID: 52900
		[Token(Token = "0x400CEA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_message;

		// Token: 0x0400CEA5 RID: 52901
		[Token(Token = "0x400CEA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_messageLength;

		// Token: 0x0400CEA6 RID: 52902
		[Token(Token = "0x400CEA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_text;

		// Token: 0x0400CEA7 RID: 52903
		[Token(Token = "0x400CEA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_typeWriterDelay;

		// Token: 0x0400CEA8 RID: 52904
		[Token(Token = "0x400CEA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_typeWriterDelay;

		// Token: 0x0400CEA9 RID: 52905
		[Token(Token = "0x400CEA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_originDelay;

		// Token: 0x0400CEAA RID: 52906
		[Token(Token = "0x400CEAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400CEAB RID: 52907
		[Token(Token = "0x400CEAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_BeginText;

		// Token: 0x0400CEAC RID: 52908
		[Token(Token = "0x400CEAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_AppendText;

		// Token: 0x0400CEAD RID: 52909
		[Token(Token = "0x400CEAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_TryFinish;

		// Token: 0x0400CEAE RID: 52910
		[Token(Token = "0x400CEAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_StopTypingSilently;

		// Token: 0x0400CEAF RID: 52911
		[Token(Token = "0x400CEAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_TryCutMessage;

		// Token: 0x0400CEB0 RID: 52912
		[Token(Token = "0x400CEB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__FinishTyping;

		// Token: 0x0400CEB1 RID: 52913
		[Token(Token = "0x400CEB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ClearMessage;

		// Token: 0x0400CEB2 RID: 52914
		[Token(Token = "0x400CEB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GetTextMessageGenerator;

		// Token: 0x0400CEB3 RID: 52915
		[Token(Token = "0x400CEB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__GetMultilineTextMessageGenerator;

		// Token: 0x0400CEB4 RID: 52916
		[Token(Token = "0x400CEB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__UpdateMaxWidth;

		// Token: 0x0400CEB5 RID: 52917
		[Token(Token = "0x400CEB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__AppendHiddenString;

		// Token: 0x0400CEB6 RID: 52918
		[Token(Token = "0x400CEB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400CEB7 RID: 52919
		[Token(Token = "0x400CEB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400CEB8 RID: 52920
		[Token(Token = "0x400CEB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
