.PHONY: clean

default:
	./latexrun --latex-args='-shell-escape' report.tex && open report.pdf

clean:
	rm -f report.out report.log report.aux

cleanall: clean
	rm -f report.pdf
	rm -rf _minted-report/
	rm -rf latex.out/
