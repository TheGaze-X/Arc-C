using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C6A RID: 15466
	[Token(Token = "0x2003C6A")]
	public class TuningChatTitleComp : TuningChatFadeCompBase
	{
		// Token: 0x06018292 RID: 98962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018292")]
		[Address(RVA = "0x10B0D10", Offset = "0x10AF910", VA = "0x1810B0D10")]
		private void _Render(string content, string name)
		{
		}

		// Token: 0x06018293 RID: 98963 RVA: 0x00099990 File Offset: 0x00097B90
		[Token(Token = "0x6018293")]
		[Address(RVA = "0x10B09B0", Offset = "0x10AF5B0", VA = "0x1810B09B0")]
		private float _GetPreferedHeight(TuningChatTitleComp.Options options)
		{
			return 0f;
		}

		// Token: 0x06018294 RID: 98964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018294")]
		[Address(RVA = "0x10B0E10", Offset = "0x10AFA10", VA = "0x1810B0E10")]
		public TuningChatTitleComp()
		{
		}

		// Token: 0x0401D609 RID: 120329
		[Token(Token = "0x401D609")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _content;

		// Token: 0x0401D60A RID: 120330
		[Token(Token = "0x401D60A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _name;

		// Token: 0x0401D60B RID: 120331
		[Token(Token = "0x401D60B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _padding;

		// Token: 0x0401D60C RID: 120332
		[Token(Token = "0x401D60C")]
		[FieldOffset(Offset = "0x48")]
		private TextGenerationSettings m_textSettings;

		// Token: 0x0401D60D RID: 120333
		[Token(Token = "0x401D60D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0401D60E RID: 120334
		[Token(Token = "0x401D60E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetPreferedHeight;

		// Token: 0x0401D60F RID: 120335
		[Token(Token = "0x401D60F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C6B RID: 15467
		[Token(Token = "0x2003C6B")]
		public struct Options
		{
			// Token: 0x0401D610 RID: 120336
			[Token(Token = "0x401D610")]
			[FieldOffset(Offset = "0x0")]
			public TuningChatTitleComp prefab;

			// Token: 0x0401D611 RID: 120337
			[Token(Token = "0x401D611")]
			[FieldOffset(Offset = "0x8")]
			public string text;

			// Token: 0x0401D612 RID: 120338
			[Token(Token = "0x401D612")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x0401D613 RID: 120339
			[Token(Token = "0x401D613")]
			[FieldOffset(Offset = "0x18")]
			public Text demiText;
		}

		// Token: 0x02003C6C RID: 15468
		[Token(Token = "0x2003C6C")]
		public class VirtualView : TuningChatFadeCompBase.VirtualViewBase<TuningChatTitleComp>
		{
			// Token: 0x06018295 RID: 98965 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018295")]
			[Address(RVA = "0x10BA7F0", Offset = "0x10B93F0", VA = "0x1810BA7F0")]
			public VirtualView(TuningChatTitleComp.Options options)
			{
			}

			// Token: 0x06018296 RID: 98966 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018296")]
			[Address(RVA = "0x10BA480", Offset = "0x10B9080", VA = "0x1810BA480", Slot = "22")]
			protected override void OnUpdateView(TuningChatTitleComp view)
			{
			}

			// Token: 0x06018297 RID: 98967 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018297")]
			[Address(RVA = "0x10BA050", Offset = "0x10B8C50", VA = "0x1810BA050", Slot = "26")]
			protected override TuningChatTitleComp FadePrefab()
			{
				return null;
			}

			// Token: 0x06018298 RID: 98968 RVA: 0x000999A8 File Offset: 0x00097BA8
			[Token(Token = "0x6018298")]
			[Address(RVA = "0x10BA200", Offset = "0x10B8E00", VA = "0x1810BA200", Slot = "27")]
			protected override float GetPreferedHeight()
			{
				return 0f;
			}

			// Token: 0x0401D614 RID: 120340
			[Token(Token = "0x401D614")]
			[FieldOffset(Offset = "0x38")]
			private TuningChatTitleComp.Options m_options;

			// Token: 0x0401D615 RID: 120341
			[Token(Token = "0x401D615")]
			[FieldOffset(Offset = "0x58")]
			private float m_cachedSize;

			// Token: 0x0401D616 RID: 120342
			[Token(Token = "0x401D616")]
			[FieldOffset(Offset = "0x60")]
			private string m_dialogContent;

			// Token: 0x0401D617 RID: 120343
			[Token(Token = "0x401D617")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401D618 RID: 120344
			[Token(Token = "0x401D618")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnUpdateView;

			// Token: 0x0401D619 RID: 120345
			[Token(Token = "0x401D619")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_FadePrefab;

			// Token: 0x0401D61A RID: 120346
			[Token(Token = "0x401D61A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPreferedHeight;
		}
	}
}
