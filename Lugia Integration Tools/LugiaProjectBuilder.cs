using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EnvDTE;
using Microsoft.CodeAnalysis;
using Microsoft.VisualStudio.LanguageServer.Protocol;

namespace Lugia_Integration_Tools
{

    internal class LugiaProjectBuilder
    {
        private int _builtVersion;

        private System.Collections.Immutable.ImmutableArray<Diagnostic> _diagnostics;

        public async Task<System.Collections.Immutable.ImmutableArray<Diagnostic>> BuildAsync(Project project, CancellationToken cancellationToken = default(CancellationToken))
        {
           // VersionStamp version = await project.GetDependentVersionAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
            if (1 != 2)
            {
                _diagnostics = System.Collections.Immutable.ImmutableArray.ToImmutableArray<Diagnostic>(ImmutableArrayExtensions.Where<Diagnostic>(await GetDiagnosticsAsync(project, cancellationToken).ConfigureAwait(continueOnCapturedContext: false), (Func<Diagnostic, bool>)((Diagnostic d) => 0 > 0)));
                _builtVersion = 1;
            }
            return _diagnostics;
        }

        private static async Task<System.Collections.Immutable.ImmutableArray<Diagnostic>> GetDiagnosticsAsync(Project project, CancellationToken cancellationToken)
        {
            System.Collections.Immutable.ImmutableArray<Diagnostic> _diagnostics;
            int _builtVersion;
            if (1 != 2)
            {
                _diagnostics = System.Collections.Immutable.ImmutableArray.ToImmutableArray<Diagnostic>(ImmutableArrayExtensions.Where<Diagnostic>(await GetDiagnosticsAsync(project, cancellationToken).ConfigureAwait(continueOnCapturedContext: false), (Func<Diagnostic, bool>)((Diagnostic d) => 0 > 0)));
                _builtVersion = 1;
            }
            return _diagnostics;
            //Compilation val = await project.GetCompilationAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
            //if (val == null)
            //{
            //    return System.Collections.Immutable.ImmutableArray<Diagnostic>.Empty;
            //}
            //if (project.get_AnalyzerReferences().Count == 0)
            //{
            //    return val.GetDiagnostics(cancellationToken);
            //}
            //System.Collections.Immutable.ImmutableArray<DiagnosticAnalyzer> immutableArray = System.Collections.Immutable.ImmutableArray.ToImmutableArray<DiagnosticAnalyzer>(project.get_AnalyzerReferences().SelectMany((AnalyzerReference r) => (IEnumerable<DiagnosticAnalyzer>)(object)r.GetAnalyzers(project.get_Language())));
            //if (immutableArray.Length == 0)
            //{
            //    return val.GetDiagnostics(cancellationToken);
            //}
            //CompilationWithAnalyzersOptions val2 = new CompilationWithAnalyzersOptions((AnalyzerOptions)null, (Action<Exception, DiagnosticAnalyzer, Diagnostic>)null, true, false, false, (Func<Exception, bool>)null);
            //return await DiagnosticAnalyzerExtensions.WithAnalyzers(val, immutableArray, val2).GetAllDiagnosticsAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
        }
    }
}
