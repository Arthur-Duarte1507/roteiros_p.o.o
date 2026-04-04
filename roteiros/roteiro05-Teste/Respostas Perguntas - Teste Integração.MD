# Respostas sobre Testes de Integração

1. **Testes de integração** são testes em que diferentes módulos do sistema são unidos e avaliados em conjunto. O principal objetivo é garantir que esses módulos se comuniquem corretamente e que o sistema funcione sem falhas.

2. **Teste unitário:** testa um componente isolado (ex.: `Service` sozinho, usando mock).  
   **Teste de integração:** testa vários componentes juntos (ex.: `Service` + `Repository` + banco de dados).

3. Não. Eles podem ser feitos manualmente ou de forma automatizada, conforme o documento.

4. Porque ajudam a identificar falhas na comunicação entre módulos, evitando erros, mau funcionamento e problemas de desempenho.

5. Exemplos:
   - **Perda de dados:** ocorre quando dados são corrompidos ou perdidos na comunicação.
   - **Resultados divergentes:** quando o resultado obtido é diferente do esperado.

6. **Etapas dos testes de integração:**
   - Identificação dos módulos
   - Definição dos cenários
   - Criação dos casos de teste
   - Execução dos testes
   - Validação dos resultados
   - Documentação

7. - **Vertical:** interação entre camadas (ex.: `Controller → Service → Repository`)
   - **Horizontal:** interação entre módulos no mesmo nível (ex.: `Service → Service`)

8. **Integração vertical**, pois envolve várias camadas do sistema até o banco de dados.

9. É validar se uma implementação segue corretamente o contrato definido por uma interface.

10. Porque envolvem múltiplos componentes reais (ex.: banco de dados, serviços), o que torna a execução mais pesada.

11. a) **Integração de serviços**  
    b) Deixa de ser integração de serviços quando envolve sistemas externos, passando a ser **integração de sistemas**.

12. **Integração de sistemas**, pois envolve comunicação com um sistema externo (API de pagamento).

13. É garantir que mudanças no código não quebrem funcionalidades existentes.  
    Isso é importante para manter o sistema funcionando corretamente após alterações.

14. **Integração de interfaces**, pois valida se a implementação respeita o contrato da interface.

15. Porque são mais lentos e complexos. Nem todos os testes precisam envolver vários componentes.

16. Podem ocorrer falhas na comunicação entre módulos, mesmo que cada parte funcione isoladamente.

17. **Integração de serviços** é um tipo específico de **integração de sistemas** (entre serviços).  
    Porém, integração de sistemas pode envolver outros elementos além de serviços, como APIs externas.

18. Exemplos:
   - **Integração vertical:** camadas internas
   - **Integração de sistemas:** API externa de pagamento

19. - **Mockadas:** simuladas (usadas em testes unitários)
   - **Reais:** componentes reais (usadas em testes de integração)

   **Impacto:** testes de integração usam dependências reais para validar o comportamento completo.

20. **Vantagens da automação:**
   - Execução mais rápida
   - Maior precisão
   - Facilidade de repetição
   - Melhor escalabilidade

21. Não. Também são necessários **testes unitários** para garantir uma qualidade mais completa.

22. Porque a API externa pode estar fora do ar ou com problemas, mesmo que o código esteja correto.

23. Uma arquitetura bem definida facilita a separação e o teste das integrações, melhorando a qualidade dos testes.

24. Não. Eles complementam os testes unitários, não os substituem.

25. O maior desafio é lidar com dependências reais (banco de dados, APIs), que tornam os testes mais complexos e instáveis.