using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Battle.DevelopTools
{
	// Token: 0x02002897 RID: 10391
	[Token(Token = "0x2002897")]
	public class AudioEmitterLogPanel : PanelTemplate
	{
		// Token: 0x060114C3 RID: 70851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114C3")]
		[Address(RVA = "0x91CB30", Offset = "0x91B730", VA = "0x18091CB30")]
		public AudioEmitterLogPanel()
		{
		}

		// Token: 0x04013516 RID: 79126
		[Token(Token = "0x4013516")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AudioEmitterLogPanel.SourceTypeToggle[] _sourceTypeToggles;

		// Token: 0x04013517 RID: 79127
		[Token(Token = "0x4013517")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AudioEmitterLogPanel.LogTypeToggle[] _logTypeToggles;

		// Token: 0x04013518 RID: 79128
		[Token(Token = "0x4013518")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private List<AudioEmitterLogPanel.LogTypeButton> _logTypeColorButtons;

		// Token: 0x04013519 RID: 79129
		[Token(Token = "0x4013519")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Toggle _mainSwitchToggle;

		// Token: 0x0401351A RID: 79130
		[Token(Token = "0x401351A")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Toggle _includeFilterToggle;

		// Token: 0x0401351B RID: 79131
		[Token(Token = "0x401351B")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Toggle _includeDuplicateToggle;

		// Token: 0x0401351C RID: 79132
		[Token(Token = "0x401351C")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Toggle _simpleEventNameToggle;

		// Token: 0x0401351D RID: 79133
		[Token(Token = "0x401351D")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private InputField _fixedLengthInput;

		// Token: 0x0401351E RID: 79134
		[Token(Token = "0x401351E")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private InputField _filterLogNumInput;

		// Token: 0x0401351F RID: 79135
		[Token(Token = "0x401351F")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private InputField _filterInput;

		// Token: 0x04013520 RID: 79136
		[Token(Token = "0x4013520")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private InputField _filterFixedLengthInput;

		// Token: 0x04013521 RID: 79137
		[Token(Token = "0x4013521")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Slider _durationSlider;

		// Token: 0x04013522 RID: 79138
		[Token(Token = "0x4013522")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Slider _fontSizeSlider;

		// Token: 0x04013523 RID: 79139
		[Token(Token = "0x4013523")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private InputField _consoleOutput;

		// Token: 0x04013524 RID: 79140
		[Token(Token = "0x4013524")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private ColorTemplate _colorTemplate;

		// Token: 0x04013525 RID: 79141
		[Token(Token = "0x4013525")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Transform _emitterLogFolder;

		// Token: 0x02002898 RID: 10392
		[Token(Token = "0x2002898")]
		public interface IBindindgs
		{
			// Token: 0x060114C4 RID: 70852
			[Token(Token = "0x60114C4")]
			void OnStart(AudioEmitterLogPanel entity);

			// Token: 0x060114C5 RID: 70853
			[Token(Token = "0x60114C5")]
			void OnUpdate(AudioEmitterLogPanel entity);

			// Token: 0x060114C6 RID: 70854
			[Token(Token = "0x60114C6")]
			void EventOnLogTypeColorBtnClicked(AudioEmitterLogPanel entity, Button button);

			// Token: 0x060114C7 RID: 70855
			[Token(Token = "0x60114C7")]
			KeyCode SwitchKeyCode();
		}

		// Token: 0x02002899 RID: 10393
		[Token(Token = "0x2002899")]
		[Serializable]
		public class SourceTypeToggle
		{
			// Token: 0x060114C8 RID: 70856 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60114C8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SourceTypeToggle()
			{
			}

			// Token: 0x04013526 RID: 79142
			[Token(Token = "0x4013526")]
			[FieldOffset(Offset = "0x10")]
			public Toggle toggle;

			// Token: 0x04013527 RID: 79143
			[Token(Token = "0x4013527")]
			[FieldOffset(Offset = "0x18")]
			public AudioEmitterLog.SourceType sourceType;
		}

		// Token: 0x0200289A RID: 10394
		[Token(Token = "0x200289A")]
		[Serializable]
		public class LogTypeToggle
		{
			// Token: 0x060114C9 RID: 70857 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60114C9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LogTypeToggle()
			{
			}

			// Token: 0x04013528 RID: 79144
			[Token(Token = "0x4013528")]
			[FieldOffset(Offset = "0x10")]
			public Toggle toggle;

			// Token: 0x04013529 RID: 79145
			[Token(Token = "0x4013529")]
			[FieldOffset(Offset = "0x18")]
			public AudioEmitterLog.LogType logType;
		}

		// Token: 0x0200289B RID: 10395
		[Token(Token = "0x200289B")]
		[Serializable]
		public class LogTypeButton
		{
			// Token: 0x060114CA RID: 70858 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60114CA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LogTypeButton()
			{
			}

			// Token: 0x0401352A RID: 79146
			[Token(Token = "0x401352A")]
			[FieldOffset(Offset = "0x10")]
			public Button button;

			// Token: 0x0401352B RID: 79147
			[Token(Token = "0x401352B")]
			[FieldOffset(Offset = "0x18")]
			public AudioEmitterLog.LogType logType;
		}
	}
}
